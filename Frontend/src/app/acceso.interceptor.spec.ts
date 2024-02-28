import { TestBed } from '@angular/core/testing';

import { AccesoInterceptor } from './acceso.interceptor';

describe('AccesoInterceptor', () => {
  beforeEach(() => TestBed.configureTestingModule({
    providers: [
      AccesoInterceptor
      ]
  }));

  it('should be created', () => {
    const interceptor: AccesoInterceptor = TestBed.inject(AccesoInterceptor);
    expect(interceptor).toBeTruthy();
  });
});
