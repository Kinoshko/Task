# Task

1. В основнов я читал код предаставленный в туториалах, на msdn и на "курсах".
Главный вывод который для себя сделал - лучший тот код, что требует минимум комментариев.
Если структура кода и имена переменных, методов и классов подобранны удачно, то код вполне читабелен и без дополнительных объяснений.

2. C - структурный язык программирования. Используют для программирования микроконтроллеров.

C++ - объектно-ориентированный язык программирования. Используют для написания крупных десктопных программ, программирования МК.

C# - оббъектно-ориентированный язык программирования.
Используют для написания десктопных программ, в веб разработке (ASP.NET), мобильные приложения. 

Python - скриптовый язык программирования. Используется для автоматизации процессов и веб-разработки.

Java - мультиплатформенный объекто-ориентированный язык программирования.
Используется в андроид-разработке, веб-разработке, десктоп-разработке, на нем пишут программы для "умных" вещей.
Наслышан, что пользуется спросом в банковской сфере. 

PHP - серверный скриптовый язык программирования. Используется в веб-разработке.

JavaScript - скриптовый язык программирования. Используется в веб-разработке.

Assembly - низкоуровневый язык программирования, который используется при программировании МК,
написании драйверов и оптимизации программ в многоязыковых системах программирования.

3. Компилятор - это программа, преобразующая програмный код написанный программистом в программу на машинном языке.
Компилятор отслиживает некоторую часть ошибок на этапе компиляции и в случае их обноружение,
не позволяет программе скомпилироваться до их устранения.
Из плюсов использования скомпилированных програм можно отметить скорость их выполнения,
так как скомпилированная программа сразу готова к использованию без промежуточных этапов.
Из минусов - скомпилированная программа, например, на Windows не будет работать на Linux. 
Есть интерпретированные языки программирование, такие как Python.
Для работы программы написанной на "питоне" нет необходимости её компилировать, но необходим "интерпретатор".
Интерпретатор преобразует исходный код в "промежуточный" и далее в машинный.
Из плюсов можно выделить доступность такого кода - в любой момент его можно изменить и не нужно тратить время на компиляцию.
Из минусов - такая программа будет работать медленнее всвязи с наличием промежуточного этапа.

4. Framework - это готовая структора с набором библиотек, вокруг которой строится приложение.
Для примера можно назвать ASP.NET и Django для питона.

5. Http - протокол передачи данных, позволяющий получить информацию с сайтов.
Https - расширение предыдущего прокола, реализуещее шифрование данных. 

6. UserProfile, UserName, Avatar, Bio, UserProfileInfo, PhotoAlbums, Photosm, Videos, Wall.

7. SqlServer, PostgreSQL, SQLite, MySQL, Oracle, Microsoft Access - реляционные базы данных, а SQL простой язык, поддерживающий реляции.
MongoDB и Cassandra - это нереляционные базы данных, как следствие - они используют свои системы запросов.

9. 
select products.name, Categories.name
from products
left join Categories
on  products.categories_id = Categories.id;
