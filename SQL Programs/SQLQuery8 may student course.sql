create table course (course_id int primary key, course_name varchar(20) );
insert into course values(1,'DOT NET')
insert into course values(2,'JAVA')

create table student (student_id int primary key, student_name varchar(20), course_id int constraint c foreign key(course_id) 
references course(course_id) );
insert into student values(1,'sahil',1)
insert into student values(2,'jay',1)
insert into student values(3,'tanmay',1)
insert into student values(4,'mona ',1)
insert into student values(5,'sachin',2)
insert into student values(6,'rahul',2)
insert into student values(7,'aachal',2)
insert into student values(8,'bharti',2)
insert into student values(9,'ankita',2)


select * from course
select * from student

select c1.course_id,c1.course_name,s1.student_name
from course c1 inner join student s1 
on c1.course_id=s1.course_id
where c1.course_name='JAVA';


select s1.student_name
from course c1 inner join student s1 
on c1.course_id=s1.course_id
where c1.course_name='Dot NET';


select ct.course_name
from course ct inner join student s1 
on ct.course_id=s1.student_id
where s1.student_name='sahil'


select student_name from student where student_id=1
(select course_id from course where course_name='DOT NET')

select course_name from course where course_id=1
(select student_id from student where student_name='mona')


