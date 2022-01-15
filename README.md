# Выполнение тестового задания АО «Новая перевозочная компания». Backend.
Frontend в [соседнем репозитории](https://github.com/Trosh-A/npk.front)
## Задание
- Есть таблица с данными. Пример таблицы приведен ниже. Будем считать, что в таблице есть несколько сотен записей; (id:int, firstName:string, lastName:string, dateOfBirth, height:int)
- Необходимо написать Web приложение, состоящее из двух отдельных приложений Frontend(желательно Vue.js) + Backent(ASP.NET Core 5+) REST API;
- Приложение должно выводить на страницу данные, с использованием [DxDataGrid компонента](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/);
- БД использовать любую или не использовать вовсе, а хранить данные в памяти или Json файле;
- В таблице должна быть возможность использовать фильтры;
- При работе с БД, если она будет, использовать EntityFramework;
- Фильтровать данные на серверной стороне.
## Особенности реализации
- Применён пакет [DevExtreme.AspNet.Data](https://www.nuget.org/packages/DevExtreme.AspNet.Data/);
- для хранения даты использован тип данных string. Если применить DateOnly или DateTime, то некорректно работает фильтр по этому полю;
- применён EF Core In-Memory Database Provider.
