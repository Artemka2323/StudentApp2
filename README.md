# Программа "StudentApp2"
 Данная программа предназначена для ведения учёта студентов.

В программе хранятся данные о студентах, такие как:
- номер;
- ФИО;
- группа;
- телефон;
- email;
- дата рождения.

Функциональные возможности приложения:
- Добавление студента;
- Изменение студента;
- Удаление студента.

Интерфейсы приложения:

![MainWindow](/Images/MainWindow.png "Главная страница со списком студентов")

![AddPageStudent](/Images/AddPageStudent.png "Страница добавления студента")

![EditPageStudent](/Images/EditPageStudent.png "Страница изменения и удаления студента")


С помощью класса **"Student"** создаётся БД в _SQLite_, который установлен в приложении пакетом _NuGet_.

Описание класса **"Student"**:
```
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    [Table("Students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Group { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DateOfBirthday { get; set; }
    }
}
```
