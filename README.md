# Выполнение тестового задания АО «Новая перевозочная компания». Backend.
Frontend в [соседнем репозитории](https://github.com/Trosh-A/npk.front)
## Задание
- Есть таблица с данными. Пример таблицы приведен ниже. Будем считать, что в таблице есть несколько сотен записей; (id:int, firstName:string, lastName:string, dateOfBirth, height:int)
- Необходимо написать Web приложение, состоящее из двух отдельных приложений Frontend(желательно Vue.js) + Backend(ASP.NET Core 5+) REST API;
- Приложение должно выводить на страницу данные, с использованием [DxDataGrid компонента](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/);
- БД использовать любую или не использовать вовсе, а хранить данные в памяти или Json файле;
- В таблице должна быть возможность использовать фильтры;
- При работе с БД, если она будет, использовать EntityFramework;
- Фильтровать данные на серверной стороне;
- В самой таблице должны быть фильтры поиска по полям Name и Height;
- Таблица должна позволять осуществлять сортировку;
- Таблица должна содержать элементы листания страниц.
## Особенности реализации
- Применён пакет [DevExtreme.AspNet.Data](https://www.nuget.org/packages/DevExtreme.AspNet.Data/);
- Для хранения даты использован тип данных string. Если применить DateOnly или DateTime, то некорректно работает фильтр по этому полю;
- Применён EF Core In-Memory Database Provider.
## Как запустить
- Скачать/клонировать репозиторий;
- Скачать зависимости из Nuget dotnet restore;
- Собрать и запустить проект с помощью dotnet-cli или в Visual Studio.
