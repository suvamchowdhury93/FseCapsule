import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
this.describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  }));
  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    this.expect(app).toBeTruthy();
  }));
  it(`should have as title 'spa-app'`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    this.expect(app.title).toEqual('spa-app');
  }));
  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    this.expect(compiled.querySelector('h1').textContent).toContain('Welcome to spa-app!');
  }));
});
