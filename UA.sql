-- Database export via SQLPro (https://www.sqlprostudio.com/allapps.html)
-- Exported by BuiDong at 17-05-2020 18:30.
-- WARNING: This file may contain descructive statements such as DROPs.
-- Please ensure that you are running the script at the proper location.


-- BEGIN TABLE dbo.__EFMigrationsHistory
IF OBJECT_ID('dbo.__EFMigrationsHistory', 'U') IS NOT NULL
DROP TABLE dbo.__EFMigrationsHistory;
GO

CREATE TABLE dbo.__EFMigrationsHistory (
	MigrationId nvarchar(150) NOT NULL,
	ProductVersion nvarchar(32) NOT NULL
);
GO

ALTER TABLE dbo.__EFMigrationsHistory ADD CONSTRAINT PK___EFMigrationsHistory PRIMARY KEY (MigrationId);
GO

-- Inserting 2 rows into dbo.__EFMigrationsHistory
-- Insert batch #1
INSERT INTO dbo.__EFMigrationsHistory (MigrationId, ProductVersion) VALUES
('20200514160813_InitialCreate', '3.1.3'),
('20200514161229_Initial', '3.1.3');

-- END TABLE dbo.__EFMigrationsHistory

-- BEGIN TABLE dbo.achievements
IF OBJECT_ID('dbo.achievements', 'U') IS NOT NULL
DROP TABLE dbo.achievements;
GO

CREATE TABLE dbo.achievements (
	AchievementID int NOT NULL IDENTITY(1,1),
	achieve nvarchar(300) NULL,
	UserId int NOT NULL
);
GO

ALTER TABLE dbo.achievements ADD CONSTRAINT PK_achievements PRIMARY KEY (AchievementID);
GO

-- Inserting 30 rows into dbo.achievements
-- Insert batch #1
INSERT INTO dbo.achievements (AchievementID, achieve, UserId) VALUES
(1, 'President, Developing Effective Leadership club of Hanoi University', 1),
(2, 'External Relation Manager of Company Insider Online Career Fair - YBOX', 1),
(3, 'Training Management Intern at FPT Corporation', 1),
(4, ' Co-founder, Hanu Clubs Ecosystem', 1),
(5, 'University scholarship for outstanding performance, received two times', 1),
(6, 'Intern, Italian Chamber of Commerce in Vietnam', 2),
(7, 'Task force, 3rd High level Dialogue on ASEAN Italy Economic Relations', 2),
(8, 'Sponsorship Supporter, Debater, United Asian Debating Championship 2019', 2),
(9, 'President, Finance - Accounting Society International School - VNU (FASIS)', 2),
(10, ' Delegate, The ASEAN & Indian Higher Education Leaders'' Conference, India', 2),
(11, ' Member of Committee on Law, Viet Nam Youth Parliament', 3),
(12, 'Delegate, Vietnam Youth for Peace and Development', 3),
(13, 'Head of Professional Department, Law School Club', 3),
(14, 'Co-founder, Project: Drink Don''t Drive', 3),
(15, 'Intern, Publics Affair Section - U.S. Embassy', 3),
(16, 'Collaborator, YouthSpeak of AIESEC', 4),
(17, ' Adjudicator, United Asia Debating Championship', 4),
(18, 'Delegate, VnuIs Future Leader', 4),
(19, 'President, Ispeech (Oratory club)', 4),
(20, 'Invited Adjudicator, Hanoi Debate Open- PreUADC', 4),
(21, 'Head of Human Resources Debate Empowering Society - AEP - NEU', 5),
(22, 'Adjudicator, Ha Noi BP 2017 - Debate Tournament', 5),
(23, 'Debater, Ha Noi Debate Tournament 2019', 5),
(24, 'Top 10 best speakers,  Eunoia InterVarsity - Debate Tournament', 5),
(25, 'Collaborator , Ha Noi Pre ABP - Debate Tournament', 5),
(26, 'Intern, Voice of Vietnam, Vietnam Journey Channel', 6),
(30, 'Liaison Officer for SEOM Lead, Deputy Secretary of Malaysian MOIT of ASEAN Meeting 2020', 6),
(31, 'Interpreter, Rector and Teacher Training Program of British University Vietnam in collaboration with MOET', 6),
(32, 'External Relations Member of Executive Committee, English Department of Hanoi University', 6),
(33, ' Leader, Philippine English Camp at Ibreeze School 2019', 6);

-- END TABLE dbo.achievements

-- BEGIN TABLE dbo.users
IF OBJECT_ID('dbo.users', 'U') IS NOT NULL
DROP TABLE dbo.users;
GO

CREATE TABLE dbo.users (
	UserID int NOT NULL IDENTITY(1,1),
	name nvarchar(100) NULL,
	nationality nvarchar(50) NULL,
	quote nvarchar(300) NULL,
	department nvarchar(300) NULL,
	image1 nvarchar(300) NULL,
	image2 nvarchar(300) NULL
);
GO

ALTER TABLE dbo.users ADD CONSTRAINT PK_users PRIMARY KEY (UserID);
GO

-- Inserting 6 rows into dbo.users
-- Insert batch #1
INSERT INTO dbo.users (UserID, name, nationality, quote, department, image1, image2) VALUES
(1, 'Dang Tuan Hung ', 'Vietnamese', 'We - the Triple I, believe that young people are those who shape the future region prosperity by maintaining a sustainable lifestyle and take actions where needed', ' FACULTY OF MANAGEMENT AND TOURISM - HANOI UNIVERSITY', 'Hưng1.jpg', NULL),
(2, 'Nguyen Dieu Linh', 'Vietnamese', 'We believe our philosophical insights in diverse key aspects and leadership-oriented expertise will imprint footprints in the journey to joint ignorant poeple to give hands.', 'INTERNATIONAL BUSINESS - INTERNATIONAL SCHOOL, VIETNAM NATIONAL UNIVERSITY', 'Linh1.jpg', NULL),
(3, 'Nguyen Quoc Anh', 'Vietnamese', 'Triple I will be the one, as the connectors who inflame the fire insight the young to anticipate for ASEAN Evironment ', 'Economic Law - Hanoi Law University', 'Quốc Anh1.jpg', 'Quốc Anh2.jpg'),
(4, 'Nguyen Trong Tuan', 'Vietnamese', 'AFMAM is an eye-opening experience where we - the futures ASEAN leaders can exchange culture and enlarge our international network', 'ACCOUNTING, ANALYZING AND AUDITING - INTERNATIONAL SCHOOL, VIETNAM NATIONAL UNIVERSITY', 'Tuấn1.jpg', NULL),
(5, 'Nguyen Thanh Van', 'Vietnamese', 'We come to AFMAM with our utmost personnel, open mindset and engage our highest commitment to the total success of AFMAM.', 'PUBLIC RELATIONS - NATIONAL ECONOMIC UNIVERSITY', 'Vân1.jpg', 'Vân2.jpg'),
(6, 'Nguyen Thao Vi', 'Vietnamese', 'We - the Triple I, work as a team with a simly principle '' I can change, you can change, together we can make a change', 'English Language Studies at Hanoi University', 'Vy1.jpg', NULL);

-- END TABLE dbo.users

IF OBJECT_ID('dbo.achievements', 'U') IS NOT NULL AND OBJECT_ID('dbo.users', 'U') IS NOT NULL
	ALTER TABLE dbo.achievements
	ADD CONSTRAINT FK_achievements_users_UserId
	FOREIGN KEY (UserId)
	REFERENCES dbo.users (UserID)
	ON DELETE Cascade;

