using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


ObjectPool<Bullet> pool = new ObjectPool<Bullet>(3);

Bullet bullet1 = pool.Get();
Bullet bullet2 = pool.Get();
Bullet bullet3 = pool.Get();


bullet1.Fire(10, 20);
bullet2.Fire(30, 40);
bullet3.Fire(50, 60);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");


Console.WriteLine("=== 풀 초과 시도 ===");
pool.Get();



Console.WriteLine("=== 반납 후 재사용 ===");
pool.Return(bullet1);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");
pool.Get();
bullet1.Fire(100, 200);
Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");
