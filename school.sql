DROP TABLE IF EXISTS
books, classes, clubs, disciplines, students, teachers, timetable,
books_archive, classes_archive, clubs_archive, disciplines_archive, students_archive, teachers_archive, timetable_archive CASCADE;

DROP ROLE IF EXISTS "SchoolDBRole";
DROP USER IF EXISTS school_user;

/* ------------- TABLES CREATION ------------- */

CREATE TABLE students (
	"id" serial PRIMARY KEY,
	"FirstName" varchar(100) NOT NULL,
	"LastName" varchar(100) NOT NULL,
	"MiddleName" varchar(100) NOT NULL,
	"Sex" char NOT NULL,
	"EntryDate" date NOT NULL DEFAULT current_date,
	"ClassID" int,
	"ClubID" int,
	"Phone" varchar(13) NOT NULL
);

CREATE TABLE teachers (
	"id" serial PRIMARY KEY,
	"FirstName" varchar(100) NOT NULL,
	"LastName" varchar(100) NOT NULL,
	"MiddleName" varchar(100) NOT NULL,
	"Sex" char NOT NULL,
	"ClassroomTeacher" bool NOT NULL DEFAULT false,
	"ClassID" int,
	"DisciplineID" int,
	"ClubID" int,
	"Phone" varchar(13) NOT NULL
);

CREATE TABLE classes (
	"id" serial PRIMARY KEY,
	"ClassName" varchar(4) NOT NULL,
	"ClassroomTeacherID" int
);

CREATE TABLE clubs (
	"id" serial PRIMARY KEY,
	"ClubName" varchar(100),
	"TeacherID" int,
	"DayOfWeek" varchar(10) NOT NULL,
	"Time" time NOT NULL
);

CREATE TABLE timetable (
	"id" serial PRIMARY KEY,
	"ClassID" int,
	"DayOfWeek" varchar(10) NOT NULL,
	"Time" time NOT NULL,
	"DisciplineID" int
);

CREATE TABLE disciplines (
	"id" serial PRIMARY KEY,
	"DisciplineName" varchar(100)
);

CREATE TABLE books (
	"id" serial PRIMARY KEY,
	"BookName" varchar(100),
	"Author" varchar(100),
	"DisciplineID" int
);

/* -------------------- X -------------------- */

/* -------------- TABLES FILLING -------------- */

INSERT INTO disciplines ("DisciplineName")
VALUES ('Алгебра'),
       ('Геометрія'),
       ('Фізика'),
       ('Хімія'),
       ('Географія'),
       ('Українська мова'),
       ('Українська література'),
       ('Фізкультура'),
       ('Астрономія'),
       ('Біологія'),
       ('Біологія і екологія'),
       ('Захист Вітчизни'),
       ('Історія України'),
       ('Інформатика');

INSERT INTO books ("BookName", "Author", "DisciplineID")
VALUES ('Алгебра (7 клас)', 'Г. П. Бевз', 1),
       ('Алгебра (8 клас)', 'Г. П. Бевз', 1),
       ('Алгебра (9 клас)', 'Г. П. Бевз', 1),
       ('Алгебра (10 клас)', 'А. Г. Мерзляк', 1),
       ('Алгебра (11 клас)', 'А. Г. Мерзляк', 1),
       ('Геометрія (7 клас)', 'Г. П. Бевз', 2),
       ('Геометрія (8 клас)', 'Г. П. Бевз', 2),
       ('Геометрія (9 клас)', 'Г. П. Бевз', 2),
       ('Геометрія (10 клас)', 'Г. П. Бевз', 2),
       ('Геометрія (11 клас)', 'Г. П. Бевз', 2),
       ('Фізика (7 клас)', 'С. В. Громов', 3),
       ('Фізика (8 клас)', 'С. В. Громов', 3),
       ('Фізика (9 клас)', 'С. В. Громов', 3),
       ('Фізика (10 клас)', 'С. В. Громов', 3),
       ('Фізика (11 клас)', 'С. В. Громов', 3),
       ('Хімія (7 клас)', 'П. П. Попель', 4),
       ('Хімія (8 клас)', 'П. П. Попель', 4),
       ('Хімія (9 клас)', 'П. П. Попель', 4),
       ('Хімія (10 клас)', 'П. П. Попель', 4),
       ('Хімія (11 клас)', 'П. П. Попель', 4),
       ('Географія (7 клас)', 'В. Ю. Пестушко', 5),
       ('Географія (8 клас)', 'В. Ю. Пестушко', 5),
       ('Географія (9 клас)', 'В. Ю. Пестушко', 5),
       ('Географія (10 клас)', 'В. Ю. Пестушко', 5),
       ('Географія (11 клас)', 'Л. Б. Паламарчук', 5),
       ('Українська мова (7 клас)', 'С. Я. Єрмоленко', 6),
       ('Українська мова (8 клас)', 'С. Я. Єрмоленко', 6),
       ('Українська мова (9 клас)', 'С. Я. Єрмоленко', 6),
       ('Українська мова (10 клас)', 'С. Я. Єрмоленко', 6),
       ('Українська мова (11 клас)', 'С. Я. Єрмоленко', 6),
       ('Українська література (7 клас)', 'О. М. Авраменко', 7),
       ('Українська література (8 клас)', 'О. М. Авраменко', 7),
       ('Українська література (9 клас)', 'О. М. Авраменко', 7),
       ('Українська література (10 клас)', 'О. М. Авраменко', 7),
       ('Українська література (11 клас)', 'О. М. Авраменко', 7),
       ('Астрономія (11 клас)', 'М. П. Пришляк', 9),
       ('Біологія (7 клас)', 'Л. І. Остапченко', 10),
       ('Біологія (8 клас)', 'Л. І. Остапченко', 10),
       ('Біологія (9 клас)', 'Л. І. Остапченко', 10),
       ('Біологія і екологія (10 клас)', 'Л. І. Остапченко', 11),
       ('Біологія і екологія (11 клас)', 'Л. І. Остапченко', 11),
       ('Захист Вітчизни (11 клас)', 'А. А. Гудима', 12),
       ('Історія України (7 клас)', 'О. В. Гісем', 13),
       ('Історія України (8 клас)', 'О. В. Гісем', 13),
       ('Історія України (9 клас)', 'О. В. Гісем', 13),
       ('Історія України (10 клас)', 'О. В. Гісем', 13),
       ('Історія України (11 клас)', 'О. В. Гісем', 13);

INSERT INTO teachers ("FirstName", "LastName", "MiddleName", "Sex", "ClassroomTeacher", "ClassID", "DisciplineID", "ClubID", "Phone")
VALUES ('Світлана', 'Крамаренко', 'Петрівна', 'f', true, 1, 1, null,'+380929515760'),
       ('Тамара', 'Захарчук', 'Михайлівна', 'f', false, null, 1, null,'+380676901627'),
       ('Данило', 'Романченко', 'Іванович', 'm', false, null, 2, null,'+380502263490'),
       ('Валерія', 'Крамарчук', 'Олександрівна', 'f', true, 2, 2, null,'+380508342576'),
       ('Володимир', 'Лисенко', 'Володимирович', 'm', false, null, 3, null,'+380505174952'),
       ('Маргарита', 'Кравчук', 'Андріївна', 'f', true, 3, 4, null,'+380506663414'),
       ('Тарас', 'Гнатюк', 'Федорович', 'm', true, 4, 5, null,'+380507794521'),
       ('Тетяна', 'Сергієнко', 'Анатоліївна', 'f', false, null, 6, null,'+380932425748'),
       ('Кіра', 'Броварчук', 'Олександрівна', 'f', true, 10, 7, null,'+380993501109'),
       ('Андрій', 'Шевченко', 'Євгенович', 'm', false, null, 8, 1,'+380965572089'),
       ('Анастасія', 'Таращук', 'Тарасівна', 'f', true, 9, 8, 3,'+380965564288'),
       ('Діана', 'Антоненко', 'Олександрівна', 'f', false, null, 9, null,'+380634422578'),
       ('Євгенія', 'Кравченко', 'Федорівна', 'f', true, 5, 10, null,'+380999439549'),
       ('Олександра', 'Іванченко', 'Миколаївна', 'f', true, 6, 11, null,'+380961969087'),
       ('Борис', 'Кравчук', 'Анатолійович', 'm', false, null, 12, null,'+380966056148'),
       ('Алла', 'Кравченко', 'Михайлівна', 'f', true, 7, 12, null,'+380507866105'),
       ('Марина', 'Антоненко', 'Михайлівна', 'f', false, null, 13, null,'+380960305659'),
       ('Вадим', 'Василенко', 'Йосипович', 'm', true, 8, 14, 5,'+380639098462'),
       ('Тетяна', 'Іванченко', 'Петрівна', 'f', false, null, 14, 9,'+380996086983'),
       ('Ярослава', 'Петренко', 'Василівна', 'f', false, null, null, 2,'+380961521033'),
       ('Сергій', 'Романченко', 'Євгенійович', 'm', false, null, null, 4,'+380673626634'),
       ('Галина', 'Петренко', 'Валентинівна', 'f', false, null, null, 6,'+380967590010'),
       ('Валерія', 'Дмитренко', 'Борисівна', 'f', false, null, null, 7,'+380991420392'),
       ('Владислав', 'Васильєв', 'Іванович', 'm', false, null, null, 8,'+380937644859'),
       ('Олексій', 'Шинкаренко', 'Петрович', 'm', false, null, null, 10,'+380965192610');

INSERT INTO clubs ("ClubName", "TeacherID", "DayOfWeek", "Time")
VALUES ('Футбол', 10, 'Понеділок', '15:45'),
       ('Бісер', 20, 'Понеділок', '15:45'),
       ('Волейбол', 11, 'Вівторок', '15:45'),
       ('Карате', 21, 'Вівторок', '15:45'),
       ('Робототехніка', 18, 'Середа', '15:45'),
       ('Танці', 22, 'Середа', '15:45'),
       ('Гімнастика', 23, 'Четвер', '15:45'),
       ('Баскетбол', 24, 'Четвер', '15:45'),
       ('Програмування', 19, 'П''ятниця', '15:45'),
       ('Настільний теніс', 25, 'П''ятниця', '15:45');

INSERT INTO classes ("ClassName", "ClassroomTeacherID")
VALUES ('7-А', 1),
       ('7-Г', 4),
       ('8-А', 6),
       ('8-Б', 7),
       ('9-А', 13),
       ('9-В', 14),
       ('10-Б', 16),
       ('10-В', 18),
       ('11-А', 11),
       ('11-В', 9);

INSERT INTO students ("FirstName", "LastName", "MiddleName", "Sex", "EntryDate", "ClassID", "ClubID", "Phone")
VALUES ('Софія', 'Васильчук', 'Олексіївна', 'f', '01.09.2010', 9, 2, '+380935292994'),
       ('Валерій', 'Іванченко', 'Петрович', 'm', '01.09.2010', 9, 1, '+380219461591'),
       ('Наташа', 'Шевчук', 'Петрівна', 'f', '01.09.2010', 9, 6, '+380931591355'),
       ('Ігор', 'Кравчук', 'Євгенович', 'm', '01.09.2010', 9, 4, '+380671923933'),
       ('Тарас', 'Захарчук', 'Йосипович', 'm', '01.09.2010', 9, 9, '+380961615305'),
       ('Олександр', 'Бондаренко', 'Олексійович', 'm', '01.09.2010', 9, 10, '+380679572444'),
       ('Юлія', 'Василенко', 'Тарасівна', 'f', '01.09.2010', 9, 7, '+380935056524'),
       ('Іван', 'Антоненко', 'Сергійович', 'm', '01.09.2010', 9, 8, '+380962974832'),
       ('Тимофій', 'Лисенко', 'Євгенійович', 'm', '01.09.2010', 9, 3, '+380639436060'),
       ('Тетяна', 'Мірошниченко', 'Борисівна', 'f', '01.09.2010', 9, 5, '+380670809652'),
       ('Владислав', 'Броварчук', 'Федорович', 'm', '01.09.2010', 9, 6, '+380962801945'),
       ('Борис', 'Пономарчук', 'Тарасович', 'm', '01.09.2010', 9, 5, '+380677260675'),
       ('Сергій', 'Шевченко', 'Андрійович', 'm', '01.09.2010', 9, 1, '+380993648707'),
       ('Денис', 'Шевченко', 'Олександрович', 'm', '01.09.2010', 9, 1, '+380637642167'),
       ('Олена', 'Пономарчук', 'Андріївна', 'f', '01.09.2010', 9, 2, '+380118137560'),
       ('Вадим', 'Бондаренко', 'Євгенович', 'm', '01.09.2010', 9, 8, '+380961972071'),
       ('Ольга', 'Іванченко', 'Євгеніївна', 'f', '01.09.2010', 9, 9, '+380635137773'),
       ('Ярослава', 'Павлюк', 'Тарасівна', 'f', '01.09.2010', 9, 5, '+380509932432'),
       ('Руслан', 'Микитюк', 'Євгенович', 'm', '01.09.2010', 9, 4, '+380966240904'),
       ('Юлія', 'Василенко', 'Сергіївна', 'f', '01.09.2010', 9, 7, '+380635576367'),
       ('Валерія', 'Павлюк', 'Євгеніївна', 'f', '01.09.2010', 9, 2, '+380673829892'),
       ('Віктор', 'Пономарчук', 'Володимирович', 'm', '01.09.2010', 9, 10, '+380674568711'),
       ('Георгій', 'Лисенко', 'Борисович', 'm', '01.09.2010', 9, null, '+380509359698'),
       ('Надія', 'Романченко', 'Олексіївна', 'f', '01.09.2010', 9, null, '+380998460777'),
       ('Ігор', 'Таращук', 'Миколайович', 'm', '01.09.2010', 9, 3, '+380991309126'),
       ('Сергій', 'Шевченко', 'Романович', 'm', '01.09.2010', 9, 3, '+380997898840'),
       ('Максим', 'Дмитренко', 'Андрійович', 'm', '01.09.2010', 9, null, '+380938590508'),
       ('Лариса', 'Сергієнко', 'Олександрівна', 'f', '01.09.2010', 9, 6, '+380507547708'),
       ('Ярослав', 'Мірошниченко', 'Сергійович', 'm', '01.09.2010', 9, 9, '+380678947778');

INSERT INTO timetable ("ClassID", "DayOfWeek", "Time", "DisciplineID")
VALUES (9, 'Понеділок', '8:30', 13),
       (9, 'Понеділок', '9:25', 3),
       (9, 'Понеділок', '10:20', 6),
       (9, 'Понеділок', '11:25', 2),
       (9, 'Понеділок', '12:25', 4),
       (9, 'Понеділок', '13:25', 9),
       (9, 'Понеділок', '14:20', 2),

       (9, 'Вівторок', '8:30', 11),
       (9, 'Вівторок', '9:25', 7),
       (9, 'Вівторок', '10:20', 1),
       (9, 'Вівторок', '11:25', 6),
       (9, 'Вівторок', '12:25', 8),
       (9, 'Вівторок', '13:25', 13),

       (9, 'Середа', '8:30', 1),
       (9, 'Середа', '9:25', 3),
       (9, 'Середа', '10:20', 7),
       (9, 'Середа', '11:25', 1),
       (9, 'Середа', '12:25', 14),
       (9, 'Середа', '13:25', 12),
       (9, 'Середа', '14:20', 11),

       (9, 'Четвер', '8:30', 2),
       (9, 'Четвер', '9:25', 2),
       (9, 'Четвер', '10:20', 14),
       (9, 'Четвер', '11:25', 5),
       (9, 'Четвер', '12:25', 3),
       (9, 'Четвер', '13:25', 14),

       (9, 'П''ятниця', '8:30', 1),
       (9, 'П''ятниця', '9:25', 14),
       (9, 'П''ятниця', '10:20', 14),
       (9, 'П''ятниця', '11:25', 7),
       (9, 'П''ятниця', '12:25', 8),
       (9, 'П''ятниця', '13:25', 1);

/* -------------------- X -------------------- */

/* --------------- FOREIGN KEYS --------------- */

ALTER TABLE students
ADD CONSTRAINT "FK_ClassID"
FOREIGN KEY ("ClassID")
REFERENCES classes ("id")
ON DELETE SET NULL;

ALTER TABLE students
ADD CONSTRAINT "FK_ClubID"
FOREIGN KEY ("ClubID")
REFERENCES clubs ("id")
ON DELETE SET NULL;

ALTER TABLE teachers
ADD CONSTRAINT "FK_ClassID"
FOREIGN KEY ("ClassID")
REFERENCES classes ("id")
ON DELETE SET NULL;

ALTER TABLE teachers
ADD CONSTRAINT "FK_DisciplineID"
FOREIGN KEY ("DisciplineID")
REFERENCES disciplines ("id")
ON DELETE SET NULL;

ALTER TABLE teachers
ADD CONSTRAINT "FK_ClubID"
FOREIGN KEY ("ClubID")
REFERENCES clubs ("id")
ON DELETE SET NULL;

ALTER TABLE classes
ADD CONSTRAINT "FK_ClassroomTeacherID"
FOREIGN KEY ("ClassroomTeacherID")
REFERENCES teachers ("id")
ON DELETE SET NULL;

ALTER TABLE clubs
ADD CONSTRAINT "FK_TeacherID"
FOREIGN KEY ("TeacherID")
REFERENCES teachers ("id")
ON DELETE SET NULL;

ALTER TABLE timetable
ADD CONSTRAINT "FK_ClassID"
FOREIGN KEY ("ClassID")
REFERENCES classes ("id")
ON DELETE CASCADE;

ALTER TABLE timetable
ADD CONSTRAINT "FK_DisciplineID"
FOREIGN KEY ("DisciplineID")
REFERENCES disciplines ("id")
ON DELETE CASCADE;

ALTER TABLE books
ADD CONSTRAINT "FK_DisciplineID"
FOREIGN KEY ("DisciplineID")
REFERENCES disciplines ("id")
ON DELETE SET NULL;

/* -------------------- X -------------------- */

/* ------------------ VIEWS ------------------ */

CREATE OR REPLACE VIEW teachers_males AS
SELECT * FROM teachers
WHERE "Sex" = 'm';

CREATE OR REPLACE VIEW teachers_females AS
SELECT * FROM teachers
WHERE "Sex" = 'f';

CREATE OR REPLACE VIEW teachers_clubs_only AS
SELECT * FROM teachers
WHERE "ClassroomTeacher" IS FALSE AND "DisciplineID" IS NULL AND "ClubID" IS NOT NULL;

CREATE OR REPLACE VIEW classroom_teachers AS
SELECT * FROM teachers
WHERE "ClassroomTeacher" IS TRUE;

/* -------------------- X -------------------- */

/* ---------------- PROCEDURES ---------------- */

-- TEACHER INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_teacher_procedure(
	"_FirstName" varchar,
	"_LastName" varchar,
	"_MiddleName" varchar,
	"_Sex" char,
	"_ClassID" int,
	"_DisciplineID" int,
	"_ClubID" int,
	"_Phone" varchar
)
AS $$
BEGIN
    INSERT INTO teachers ("FirstName", "LastName", "MiddleName", "Sex", "ClassID", "DisciplineID", "ClubID", "Phone")
    VALUES ("_FirstName", "_LastName", "_MiddleName", "_Sex", "_ClassID", "_DisciplineID", "_ClubID", "_Phone");
END
$$
language plpgsql;

-- CLASS INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_class_procedure(
    "_ClassName" varchar,
    "_ClassroomTeacherID" int
)
AS $$
BEGIN
    INSERT INTO classes ("ClassName", "ClassroomTeacherID")
    VALUES ("_ClassName", "_ClassroomTeacherID");
END
$$
language plpgsql;

-- CLUB INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_club_procedure(
    "_ClubName" varchar,
    "_TeacherID" int,
    "_DayOfWeek" varchar,
    "_Time" time
)
AS $$
BEGIN
    INSERT INTO clubs ("ClubName", "TeacherID", "DayOfWeek", "Time")
    VALUES ("_ClubName", "_TeacherID", "_DayOfWeek", "_Time");
END
$$
language plpgsql;

-- TIMETABLE INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_timetable_procedure(
    "_ClassID" int,
    "_DayOfWeek" varchar,
    "_Time" time,
    "_DisciplineID" int
)
AS $$
BEGIN
    INSERT INTO timetable ("ClassID", "DayOfWeek", "Time", "DisciplineID")
    VALUES ("_ClassID", "_DayOfWeek", "_Time", "_DisciplineID");
END
$$
language plpgsql;

-- DISCIPLINE INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_discipline_procedure("_DisciplineName" varchar)
AS $$
BEGIN
    INSERT INTO disciplines ("DisciplineName")
    VALUES ("_DisciplineName");
END
$$
language plpgsql;

-- BOOK INSERT PROCEDURE
CREATE OR REPLACE PROCEDURE insert_book_procedure(
    "_BookName" varchar,
    "_Author" varchar,
    "_DisciplineID" int
)
AS $$
BEGIN
    INSERT INTO books ("BookName", "Author", "DisciplineID")
    VALUES ("_BookName", "_Author", "_DisciplineID");
END
$$
language plpgsql;

/* -------------------- X -------------------- */

/* ---------------- FUNCTIONS ---------------- */

-- STUDENTS SELECT FUNCTION
CREATE OR REPLACE FUNCTION students_select()
RETURNS SETOF students AS $$
BEGIN
    RETURN QUERY
    SELECT * FROM students ORDER BY "id";
END
$$
language plpgsql;

-- STUDENTS INSERT FUNCTION
CREATE OR REPLACE FUNCTION students_insert(
    "_FirstName" varchar,
	"_LastName" varchar,
	"_MiddleName" varchar,
	"_Sex" char,
	"_EntryDate" date,
	"_ClassID" int,
	"_ClubID" int,
	"_Phone" varchar
)
RETURNS int AS $$
BEGIN
    IF "_EntryDate" IS NULL THEN
        INSERT INTO students("FirstName", "LastName", "MiddleName", "Sex", "EntryDate", "ClassID", "ClubID", "Phone")
        VALUES ("_FirstName", "_LastName", "_MiddleName", "_Sex", DEFAULT, "_ClassID", "_ClubID", "_Phone");
    ELSE
        INSERT INTO students("FirstName", "LastName", "MiddleName", "Sex", "EntryDate", "ClassID", "ClubID", "Phone")
        VALUES ("_FirstName", "_LastName", "_MiddleName", "_Sex", "_EntryDate", "_ClassID", "_ClubID", "_Phone");
    END IF;
    RETURN CASE
        WHEN FOUND THEN 1
        ELSE 0
    END;
END
$$
language plpgsql;

-- STUDENTS UPDATE FUNCTION
CREATE OR REPLACE FUNCTION students_update(
	"_id" int,
	"_FirstName" varchar,
	"_LastName" varchar,
	"_MiddleName" varchar,
	"_Sex" char,
	"_EntryDate" date,
	"_ClassID" int,
	"_ClubID" int,
	"_Phone" varchar
)
RETURNS int AS
$$
BEGIN
    UPDATE students
    SET
        "FirstName" = "_FirstName",
        "LastName" = "_LastName",
        "MiddleName" = "_MiddleName",
        "Sex" = "_Sex",
        "EntryDate" = "_EntryDate",
        "ClassID" = "_ClassID",
        "ClubID" = "_ClubID",
        "Phone" = "_Phone"
    WHERE "id" = "_id";
    RETURN CASE
        WHEN FOUND THEN 1
        ELSE 0
    END;
END
$$
language plpgsql;

-- STUDENTS DELETE FUNCTION
CREATE OR REPLACE FUNCTION students_delete("_id" int)
RETURNS INT AS $$
BEGIN
    DELETE FROM students
    WHERE "id" = "_id";
    RETURN CASE
        WHEN FOUND THEN 1
        ELSE 0
    END;
END
$$
language plpgsql;

-- NUMBER OF LESSONS ON A GIVEN DAY FOR SPECIFIED CLASS FUNCTION
CREATE OR REPLACE FUNCTION lessons_count_on_day_by_class("_ClassName" varchar, "_DayOfWeek" varchar)
RETURNS bigint AS $$
DECLARE
    result bigint;
BEGIN
    SELECT COUNT(*) INTO result FROM timetable
    WHERE "DayOfWeek" = "_DayOfWeek" AND "ClassID" IN (
        SELECT "id" FROM classes
        WHERE "ClassName" = "_ClassName"
    );
    RETURN result;
END
$$
language plpgsql;

-- NUMBER OF STUDENTS IN THE SPECIFIED CLUB FUNCTION
CREATE OR REPLACE FUNCTION students_count_by_club("_ClubName" varchar)
RETURNS bigint AS $$
DECLARE
    result bigint;
BEGIN
    SELECT COUNT(*) INTO result FROM students
    WHERE "ClubID" IN (
        SELECT "id" FROM clubs
        WHERE "ClubName" = "_ClubName"
    );
    RETURN result;
END
$$
language plpgsql;

-- NUMBER OF BOOKS FOR THE SPECIFIED DISCIPLINE FUNCTION
CREATE OR REPLACE FUNCTION books_count_by_discipline("_DisciplineName" varchar)
RETURNS bigint AS $$
DECLARE
    result bigint;
BEGIN
    SELECT COUNT(*) INTO result FROM books
    WHERE "DisciplineID" IN (
        SELECT "id" FROM disciplines
        WHERE "DisciplineName" = "_DisciplineName"
    );
    RETURN result;
END
$$
language plpgsql;

-- STUDENTS IN SPECIFIED CLASS FUNCTION
CREATE OR REPLACE FUNCTION get_students_by_class("_ClassName" varchar)
RETURNS SETOF students AS $$
BEGIN
    RETURN QUERY
    SELECT * FROM students
    WHERE "ClassID" IN (
        SELECT "id" FROM classes
        WHERE "ClassName" = "_ClassName"
    );
end
$$
language plpgsql;

-- CLASSES AND THEIR CLASSROOM TEACHERS FUNCTION
CREATE OR REPLACE FUNCTION get_classes_info()
RETURNS TABLE (
    "id" int,
	"ClassName" varchar,
	"ClassroomTeacherID" int,
	"FirstName" varchar,
	"LastName" varchar,
	"MiddleName" varchar,
	"Sex" char,
	"DisciplineID" int,
	"ClubID" int,
	"Phone" varchar
) AS $$
BEGIN
    RETURN QUERY
    SELECT c."id", c."ClassName", c."ClassroomTeacherID",
           t."FirstName", t."LastName", t."MiddleName", t."Sex", t."DisciplineID", t."ClubID", t."Phone"
    FROM classes c
    JOIN teachers t ON c."ClassroomTeacherID" = t."id";
END
$$
language plpgsql;

-- ALL PEOPLE NAMES THAT SOMEHOW RELATES TO THE SPECIFIED CLASS FUNCTION
CREATE OR REPLACE FUNCTION get_people_relates_class("_ClassName" varchar)
RETURNS TABLE (
    "Position" text,
    "FirstName" varchar,
    "LastName" varchar,
    "MiddleName" varchar,
    "Phone" varchar
) AS $$
BEGIN
    RETURN QUERY
    SELECT 'student' AS "Position", students."FirstName", students."LastName", students."MiddleName", students."Phone" FROM students
    WHERE "ClassID" IN (
        SELECT "id" FROM classes
        WHERE "ClassName" = "_ClassName"
    )
    UNION ALL
    SELECT 'teacher' AS "Position", teachers."FirstName", teachers."LastName", teachers."MiddleName", teachers."Phone" FROM teachers
    WHERE "ClassID" IN (
        SELECT "id" FROM classes
        WHERE "ClassName" = "_ClassName"
    ) OR "DisciplineID" IN (
        SELECT "DisciplineID" FROM timetable
        WHERE timetable."ClassID" IN (
            SELECT classes."id" FROM classes
            WHERE "ClassName" = "_ClassName"
        )
    )
    ORDER BY "LastName";
END
$$
language plpgsql;

/* -------------------- X -------------------- */

/* ----------------- TRIGGERS ----------------- */

-- AUTOMATICALLY CHANGING CLASSROOMTEACHER VALUE
CREATE OR REPLACE FUNCTION classroom_teacher_check()
RETURNS TRIGGER AS $$
BEGIN
    CASE new."ClassID" IS NOT NULL
        WHEN TRUE THEN new."ClassroomTeacher" = true;
        ELSE new."ClassroomTeacher" = false;
    END CASE;
    RETURN new;
END
$$
language plpgsql;

CREATE TRIGGER "ClassroomTeacherTrigger"
BEFORE INSERT OR UPDATE ON teachers
FOR EACH ROW EXECUTE PROCEDURE classroom_teacher_check();

-- BOOKS ARCHIVE
CREATE TABLE IF NOT EXISTS books_archive (
    LIKE books,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION books_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO books_archive ("id", "BookName", "Author", "DisciplineID", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."BookName", old."Author", old."DisciplineID", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "BooksArchiveTrigger"
AFTER DELETE ON books
FOR EACH ROW EXECUTE PROCEDURE books_archive_function();

-- CLASSES ARCHIVE
CREATE TABLE IF NOT EXISTS classes_archive (
    LIKE classes,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION classes_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO classes_archive ("id", "ClassName", "ClassroomTeacherID", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."ClassName", old."ClassroomTeacherID", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "ClassesArchiveTrigger"
AFTER DELETE ON classes
FOR EACH ROW EXECUTE PROCEDURE classes_archive_function();

-- CLUBS ARCHIVE
CREATE TABLE IF NOT EXISTS clubs_archive (
    LIKE clubs,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION clubs_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO clubs_archive ("id", "ClubName", "TeacherID", "DayOfWeek", "Time", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."ClubName", old."TeacherID", old."DayOfWeek", old."Time", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "ClubsArchiveTrigger"
AFTER DELETE ON clubs
FOR EACH ROW EXECUTE PROCEDURE clubs_archive_function();

-- DISCIPLINES ARCHIVE
CREATE TABLE IF NOT EXISTS disciplines_archive (
    LIKE disciplines,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION disciplines_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO disciplines_archive ("id", "DisciplineName", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."DisciplineName", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "DisciplinesArchiveTrigger"
AFTER DELETE ON disciplines
FOR EACH ROW EXECUTE PROCEDURE disciplines_archive_function();

-- STUDENTS ARCHIVE
CREATE TABLE IF NOT EXISTS students_archive (
    LIKE students,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION students_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO students_archive ("id", "FirstName", "LastName", "MiddleName", "Sex", "EntryDate", "ClassID", "ClubID", "Phone", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."FirstName", old."LastName", old."MiddleName", old."Sex", old."EntryDate", old."ClassID", old."ClubID", old."Phone", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "StudentsArchiveTrigger"
AFTER DELETE ON students
FOR EACH ROW EXECUTE PROCEDURE students_archive_function();

-- TEACHERS ARCHIVE
CREATE TABLE IF NOT EXISTS teachers_archive (
    LIKE teachers,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION teachers_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO teachers_archive ("id", "FirstName", "LastName", "MiddleName", "Sex", "ClassroomTeacher", "ClassID", "DisciplineID", "ClubID", "Phone", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."FirstName", old."LastName", old."MiddleName", old."Sex", old."ClassroomTeacher", old."ClassID", old."DisciplineID", old."ClubID", old."Phone", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "TeachersArchiveTrigger"
AFTER DELETE ON teachers
FOR EACH ROW EXECUTE PROCEDURE teachers_archive_function();

-- TIMETABLE ARCHIVE
CREATE TABLE IF NOT EXISTS timetable_archive (
    LIKE timetable,
    "DeletedDate" timestamp,
    "DeletedBy" name
);

CREATE OR REPLACE FUNCTION timetable_archive_function()
RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO timetable_archive ("id", "ClassID", "DayOfWeek", "Time", "DisciplineID", "DeletedDate", "DeletedBy")
    VALUES (old."id", old."ClassID", old."DayOfWeek", old."Time", old."DisciplineID", current_timestamp, session_user);
    RETURN new;
end
$$
language plpgsql;

CREATE TRIGGER "TimetableArchiveTrigger"
AFTER DELETE ON timetable
FOR EACH ROW EXECUTE PROCEDURE timetable_archive_function();

/* -------------------- X -------------------- */

/* ------------- INDIVIDUAL USER ------------- */

CREATE ROLE "SchoolDBRole";
REVOKE ALL ON SCHEMA public FROM "SchoolDBRole";
REVOKE CREATE ON SCHEMA public FROM public;

GRANT SELECT, INSERT, UPDATE, DELETE, REFERENCES, TRIGGER
ON books, classes, clubs, disciplines, students, teachers, timetable
TO "SchoolDBRole";

GRANT INSERT
ON books_archive, classes_archive, clubs_archive, disciplines_archive, students_archive, teachers_archive, timetable_archive
TO "SchoolDBRole";

GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA public
TO "SchoolDBRole";

CREATE USER school_user WITH PASSWORD 'school' IN ROLE "SchoolDBRole";

/* -------------------- X -------------------- */