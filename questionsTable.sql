CREATE TABLE Questions (
	QuestionNum smallint NOT NULL IDENTITY(1,1) PRIMARY KEY,
	QuestionText varchar(100) NOT NULL,
	Answer1 varchar(2) NOT NULL,
	Answer1Text varchar(100) NOT NULL,
	Answer2 varchar(2) NOT NULL,
	Answer2Text varchar(100) NOT NULL,
	Answer3 varchar(2) NOT NULL,
	Answer3Text varchar(100) NOT NULL,
	Answer4 varchar(2) NOT NULL,
	Answer4Text varchar(100) NOT NULL,
	Image varchar(100),
	CategoryID smallint
);