Insert Into Student Values('00012', 'John Smith', '902-5556');
Insert Into Student Values('00014', 'Raj Sharma', '902-8596');
Insert Into Student Values('00015', 'Lee Wang', '902-7845');
Insert Into Student Values('00016', 'Anan Obj', '902-8974');


Insert Into Course Values('001', 'Mathematics');
Insert Into Course Values('002', 'Physics');
Insert Into Course Values('003', 'Chemistry');


Insert Into StudentCoursePoints Values('001', '00012', 86);
Insert Into StudentCoursePoints Values('001', '00014', 75);
Insert Into StudentCoursePoints Values('001', '00016', 96);
Insert Into StudentCoursePoints Values('002', '00015', 92);
Insert Into StudentCoursePoints Values('002', '00012', 63);
Insert Into StudentCoursePoints Values('002', '00016', 58);
Insert Into StudentCoursePoints Values('002', '00014', 78);
Insert Into StudentCoursePoints Values('003', '00014', 83);
Insert Into StudentCoursePoints Values('003', '00015', 65);
Insert Into StudentCoursePoints Values('003', '00012', 95);

--ADD additional rows to John Smith to test the avg Query
Insert Into StudentCoursePoints Values('001', '00012', 58);
Insert Into StudentCoursePoints Values('002', '00012', 95);
Insert Into StudentCoursePoints Values('003', '00012', 76);


