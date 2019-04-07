import { TestBed } from '@angular/core/testing';

import { TaskManagerService } from './task-manager.service';

this.describe('TaskManagerService', () => {
  beforeEach(() => this.TestBed.configureTestingModule({}));

  it('should be created', this.async(() => {
    const service: TaskManagerService = TestBed.get(TaskManagerService);
    this.expect(service).toBeTruthy();
  }));

  
});
