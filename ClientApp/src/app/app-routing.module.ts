import { Routes, RouterModule } from '@angular/router';
import { TextAnalyzerComponent } from './_components/text-analyzer/text-analyzer.component';

const routes: Routes = [
    { path: '', component: TextAnalyzerComponent },
];

export const AppRoutingModule = RouterModule.forRoot(routes);
