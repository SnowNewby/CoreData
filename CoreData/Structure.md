MyApp/
├── MyApp.Domain/                    # Слой домена
│   ├── Models/                      # Бизнес модели
│   │   ├── User.cs
│   │   ├── Order.cs
│   │   └── Product.cs
│   ├── ValueObjects/                # объекты
│   │   ├── Email.cs
│   │   ├── Address.cs
│   │   └── Money.cs
│   ├── Enums/
│   │   ├── UserStatus.cs
│   │   └── OrderStatus.cs
│   ├── Interfaces/                  # Интерфейсы репозиториев
│   │   ├── IUserRepository.cs
│   │   └── IOrderRepository.cs
│   ├── Services/                    # Доменные сервисы
│   │   ├── UserService.cs
│   │   └── OrderService.cs
│   └── Exceptions/
│       └── DomainExceptions.cs
│
├── MyApp.Application/               # Слой приложения
│   ├── DTOs/                        # Data Transfer Objects
│   │   ├── Requests/               # Входные DTO
│   │   │   ├── CreateUserRequest.cs
│   │   │   ├── UpdateUserRequest.cs
│   │   │   └── LoginRequest.cs
│   │   └── Responses/              # Выходные DTO
│   │       ├── UserResponse.cs
│   │       ├── UserListResponse.cs
│   │       └── AuthResponse.cs
│   ├── Interfaces/                  # Интерфейсы сервисов приложения
│   │   ├── IUserAppService.cs
│   │   └── IAuthAppService.cs
│   ├── Services/                    # Сервисы приложения (оркестрация)
│   │   ├── UserAppService.cs
│   │   └── AuthAppService.cs
│   ├── Mappers/                     # Маппинг между слоями
│   │   ├── UserMapper.cs
│   │   └── OrderMapper.cs
│   └── Validators/                  # Валидация DTO
│       ├── CreateUserValidator.cs
│       └── LoginValidator.cs
│
├── MyApp.Infrastructure/            # Инфраструктура (работа с БД)
│   └── Data/
│       ├── Context/                # Контекст БД
│       │   └── AppDbContext.cs
│       ├── Entities/               # DAO - сущности БД
│       │   ├── UserEntity.cs
│       │   ├── OrderEntity.cs
│       │   └── ProductEntity.cs
│       ├── Configurations/         # Конфигурации маппинга
│       │   ├── UserConfiguration.cs
│       │   └── OrderConfiguration.cs
│       └── Repositories/           # Реализация репозиториев (DAO)
│           ├── UserRepository.cs
│           └── OrderRepository.cs
│
└── MyApp.API/                      # Слой представления
├── Controllers/
│   ├── UsersController.cs
│   └── AuthController.cs
└── Middleware/
└── ErrorHandlingMiddleware.cs