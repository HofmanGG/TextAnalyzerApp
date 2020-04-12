import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { first } from 'rxjs/operators';
import { TextMetricsService } from 'src/app/_services/text-metrics.service';
import { Observable, BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-text-analyzer',
  templateUrl: './text-analyzer.component.html',
  styleUrls: ['./text-analyzer.component.css']
})
export class TextAnalyzerComponent implements OnInit {
  textForm: FormGroup;

  metrics$ = new BehaviorSubject<TextMetrics>(null);

  loading: boolean;
  submitted: boolean;

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private textAnalyzerService: TextMetricsService
    ) {
  }

  ngOnInit() {
    this.textForm = this.fb.group({
      textToAnalyze: ['', [Validators.required]]
    });
  }

  get f() { return this.textForm.controls; }

  onSubmit() {
    this.submitted = true;

    if (this.textForm.invalid) {
      return;
    }

    this.loading = true;

    this.textAnalyzerService.GetMetrics(this.textForm.value)
      .pipe(first())
      .subscribe(
        data => {
          this.metrics$.next(data);

          this.submitted = false;
          this.loading = false;
        },
        error => {
          this.submitted = false;
          this.loading = false;
        });
  }
}
