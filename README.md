# Организация работы с домашними заданиями.
Для работы с домашними заданиями создаем на ПК в VSCode  основную папку с названием, например, `Home_Tasks`,
- создаем в ней репозиторий командой git init,
- и создаем в ней файл .gitignore командой dotnet new gitignore ( в него автоматически будет вставлено нужное наполнение),
- git add .gitignore,
- git commit -m “Added .gitignore”,
- создаем в папке Home_Tasks  подпапку Task00 командой create New Folder,
- git add Task00/,
- dotnet new console,
- git commit -m “Added project Task00”,
Отправляем созданный репозиторий в предварительно созданный в аккаунте github удаленный репозиторий, после выполнения трех команд, указанных на странице github-аккаунта при создании удаленного репозитория. Команды отправляются, когда находимся в основной папке.
Для работы в основной папке и для работы с каждым проектом создаем отдельные терминалы, и для удобства именуем каждый из них соответствующим образом.
Далее изменения, сделанные в каком-либо проекте, отправляем в удаленный репозиторий краткой командой git push.
Домашнее задание отправляется в окно отправки домашних заданий, находящееся в конце урока, в виде url-адреса моего репозитория, размещенного в моем github-аккаунте.  

