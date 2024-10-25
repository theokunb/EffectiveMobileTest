# Effective Mobile C# Тестовое задание.

Разработано на Visual Studio 2022 Community Web Api.

Используется БД Postgres, EF core, Docker desktop, Automapper, Mediatr, FluentValidation, Serilog.

### Что бы запустить.
- нужно запустить контейнер Postgres `docker-compose -f docker-compose.yaml up -d`.
- запустить миграцию из консоли диспетчера пакетов `update-database`.
- запустить проект F5 или коммандой `dotnet run`.
- перейти по ардесу `https://localhost:7156/swagger/index.html`.

### Описание.
- Контроллер `Order` отвечает за заказы, в файлах миграции есть исходные данные, немножко.
- Что бы отфильтровать заказы по району и по времени нужно использовать методы `GET/api/FilteredOrder/FilterByParams` и `POST/api/FilteredOrder/FilterByFile`.
- Полученный `Guid` сохраняется в таблицу и создаются дополнительные сущности в вспомогательной таблице связанные с `Orders`.
- Что бы получить отфильтрованные заказы нужно вызвать метод `GET/api/FilteredOrder/{id}`.
- файл filterFile.json служит приметом для загрузки в метод `POST/api/FilteredOrder/FilterByFile`.
- Логирование записывается в консоли и файле `/logs/log-*.txt`.
