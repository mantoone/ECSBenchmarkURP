# Unity ECS Benchmark

Benchmark Unity's ECS against other ECS implementations.

## Benchmark setup
10 M entities, 2 components and 2 simple systems updating the data of those components. Measuring the time taken by one game loop.

## Unity ECS results

Update time 41 milliseconds.

PC specs:
- OS: Windows 10
- CPU: AMD Ryzen 7 3700X Eight-Core Processor
- RAM: 16GB

## Results from [ecs_benchmark](https://github.com/abeimler/ecs_benchmark):

Best performing ECS framework has update time of 59 milliseconds.

PC specs:
 - OS: 4.19.81-1-MANJARO x86_64 GNU/Linux
 - CPU: AMD Ryzen 5 1600 Six-Core Processor
 - RAM: 16GB
