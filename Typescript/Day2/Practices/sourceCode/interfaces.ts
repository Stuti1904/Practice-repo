interface A {
    x: number;
    y: number;
  }
  class C implements A {
    x = 0;
    y=0;
  }
  const c = new C();
  c.y = 10;
  console.log(`${c.y}`);