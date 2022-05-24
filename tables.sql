create database coursach
use coursach

create table Admin(
    Name varchar(40) not null primary key,
	Password varchar(100) not null,
)

create table User_(
    Username varchar(40) not null primary key,
	Password varchar(100) not null
)

create table Era(
    Id int primary key,
	PicturePath varchar(300),
    Name varchar(100),
	ShortDescription varchar(200),
    Description varchar(1500),
	Category varchar(100)
)

create table Travel(
	Id int primary key,
	Username varchar(40) foreign key references User_(Username),
	EraId int foreign key references Era(id),
)

create table Feedback
(
	Id int primary key,
	Username varchar(40) foreign key references User_(Username),
	Description varchar(400),
)

use coursach

insert into Admin
values 
('admin', 'admin')

insert into Era
values
(1, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\EarlyPaleolit.jpg', '������ ��������', '������ ����� �������', '������ �������� � ������ � ������� ������������, ���������� � ����� ����� ��������, � ������� �������� ������ ������������� �������� ������ �������� ������������ �������� Homo habilis. ��� ���� ������������ ������� �����������, ��������� ��� ������, �������� (����� ������� �����) � ������. Homo habilis ������� �������� ������ � ����� ����������� ��������, ������� �������������� � �������� ����� � �������� �����������. ������� � ��� ����� ���� ������������ ��������������� �� ���� ���� ������ �������� � �������������� ������������ ��������, ��� ��� ����� � ��� ����� �� ���� ��� ��������������.
����� 1,5 ��� ��� ����� �������� ����� �������� ������������ ��� Homo erectus. ������������� ������� ���� (����������) ��������� ������������ ����� � ��������� ����� ������� ������� ����������� �� �����, � ����� ��������� ���� ����� �� ���� �������� ����, ��� �������������� ��������� �� ����� ����������� � �����. ����� 1 ��� ��� ����� ������� ������� ������ � ����� ������������ �������� ������.
���������� ����������� ����� ���������� �� ������ ������������ ����� (������������, ������������� � ����� �����, ��� ������ �� ������, ��������, ������). ������ ������ � � ����� �������� ����������� ��������, ����������, �������� �����������. ������������� ������������ ����������� � �������������� � �����, ���� ���� ������� ����� �����.
��������� ������ ������� ���������, ������� ������ �� 337 000 �� 300 000 ��� �����.', '����������� ���'),
(2, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\MiddlePaleolit.jpg', '������� ��������', '������ ����', '������� �������� � �����, ��������� � ������ �� 200 000 �� 40 000 ��� �����. ����� ������ ��������� ������������� �������� ����������. ��������������� ������� ����������� �������� � ���������� �������� ����������� (������� �������� ���������) ���������� ����������� �� ���� ��������� �� ������� ���������� ������. ����������� ������� ���������� ��������������� ����������. ���������� � ������ ���������� �� �����. C������ ���������� � �������� �����, ��������� ���, ������� ��������. � ����������� � ��������� ������ ���������� �������� ��������� � 70 ��� ������, ��� ������� ���������. ������������ ���������� ������� ������ � ��������, ��� ���������� ������� ��� �������� ����� ��� � �������.
������������������� ������������ �������� ������ �����. �������� ��������� ���� ������� ����� �������� ���������. ��� ��������������� ������ ������� � ������� �� ���������� ��������������� ������������ ���������. ��� ���������� ���������� ����. ����������� ������������ ������ ����� � ��������� �������� ������������ � � ������� ���������, �� ����������� ����������. ������ ������ ����������� � ��������, ����� ������������� �� �������. ���������� ������������� ����������� � ����������� ������ �����, ������� �������������� � ������� ������� ����� � ������, �������� � ����������� ������. �������� ������ ����� ������ � ������� � ����� �������������� �����. ����������� ������ ����� ������������������: ��� ������� ��� ��������� ������ � ����, ���������, ������� � ���� ���������.', '����������� ���'),
(3, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\LatePaleolit.jpg', '������� ��������', '����� ������������ ����', '����� 50 000 ��� ����� ������� �������� ��������� ����������. ������ �����-���� ��������������� �������, ������� �� ���� �����������, ��������� ��������� ������������� ������� � ����������. ������� � ������, � ����� � � ������ �������� ����� �������� ��������� ������� �� ����� � ����, � ����� ����������� ����������� ���������� ������������ �������� ���������. ���� �� �������� � ��������������� ������ �������, � ��� ����� ���� ��������� ������ ����. � ������� ����������� 3�4 ����� ��� ����� ���������� ���������������� � � ������, ��� ������� � ������� ����� ����������� ��������� �, ��������, ����� �������� ���������� � ��������� ��������������, ��������������� � ���������� �� ������. ���������, ������� ������� �������� �������������, �� �������� ��������� ����� ���-������ �� ����������� ������� ��-���-��-����-����.
��������� �������� � �������� ����������� ���������� ������� ����������� ������� ������������� �������������� ��� ������� �������� � ������������. ��������� ������������� �������� ������ ��� ������������ ��� � ��������� ���� ������� ��������.
��������� �������� ��������� �������� �������������� ������ ��������������� �����, �������������� ������ � ������� �������� �� ����� � ����, �������� ��������, ����������, � ����� ��������� ������������ ���������� ������ �� ����� �� �������������, ��� ��������� ������������ ������� ������� ��������� ������. ����������� ��������� ��������, ������ � ������������ ��������� � �������, ������������ ��������� ������������.', '����������� ���'),
(4, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\AncientGreece.jpg', '������� ������', '������� ������� ������� ������', '������� ������� ������ �������� ����� �� ��������� ������ ������� �������� ����, ��������� ��������� ��������� ������� � ����������, ������� �������� � ����������� � ������� �������� ������� � ���������������. ������� ������� ������ ������� �������������, ������� � ������� ������������ � ��������������� ��������, ������� ������������ �� ���������� ����������� ����������� � � �������� �������, � ����� ������, �� �. ������� � � �������������. ��� ���������� � ������ III�II ����������� �� �. �. �� ������������� ������ ��������������� ����������� �� ������� ����, � ������������� �� II�I ��. �� �. �., ����� ��������� � ��������������� ����������� ���������� ��������������� ���� ��������� ����� � �������� � ������ ������� ����������������� �������.
�� ���������������� ������ ������� ������� ����� ������� ������������ ������������� �������, ���������� �� ��������� ������������� �������� � ��������� ��������, ����������� ������������ ���������, �������� ����������� � ��������������� �����������, ������� ��������, ��������� �������� ����������� �� �������� ������� � ������� ��������. ��� ���������� ��������������� ����������� ��������� ������� ������������ �������, ��������� ����������� ��� ������������ �������� ������� ��������������� � ����� �������� ����������.', '������� ���'),
(5, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\AncientEast.jpg', '������� ������', '������� ������� �������� �������', '������������� ������ ����������� � ������ � ������ (������ �������� IV ����������� �� �. �.) ����� �������� ��� ������� ���������. � ���������� ���� ����������� ������ ��������� �������������� ������. �������������� �������������� ������� � �� ���������� ���� ������� � �������������.
�������� ������ ��������������� ����������� ��������� � ������� ������� ��� � ����, ������� � �����, ���� � �����, ������. ������������� ������������� �������� ������ ���� ��� ���������� ��������� ����� ����� � ����������� ������������, ��������� �������� ���������������� ����.
���������������� ���������, ������� ������ ��������� �����������, ���������� ���������� ��������� � ������������� ��� �� ��������� ����������� ������������� ������ �������, ���������� ������������� ����������� �� ��� ����� ����� � ��������� ���� ��� ����� ������ � ������� ������.
��������������� � ������� �������������, ������� ������ � ���������, ������� � ������������� � ������������ ��������� ������, � �������� ����������� ��������� ����������� �����, ������� ������, �������� ��� ��������� � ������ �������� ������������ �������, ���������� ��� �������� �����������.
�������-�������� �������, ���������������, ��������� � ��������������� ��������� ���� ������������ ����������� � �� �������� �� ��������������� ����������� ��� ������� ����������� �������� ������,��������� ����������� ������� ����� �� ��������� ����� � ��� ������������ �������� ���������� ������ � ������������� ���������������� ������������.', '������� ���'),
(6, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\AncientRome.jpg', '������� ���', '���� �� ������', '������� ��� � ���� �� ����� �������� ����������� �������� ����, ����������� ����������, �������� ��� �������� �� �������� ������ (Roma � ���), � ���� ������� ���������� � ����� ������������ ���������� � ������. ����� ���� �������� � �������� ���������� �������, ������������ ����������, ��������� � ����������. ����������� ������� �� ����������� ������������� ����������� ������� �������� �������� � ������� ������. ���� ������ ���������� ������� ��� ������ �� II ���� �. �., ����� ��� ��� ��������� ��������� ������������ �� ����������� ������ �� ������ �� ������ �� ��� � �� ����� �� ������� �� ���������� �� ������.
����������� ������ �������������� ����������� ��� ���������. ������������� �������� � ������ ������� ��� ������� ���, ����� �������� ������������ ��������� �������� (�����, ������������� ����������� ������������ ��� ����� �����) � ������� (���������� ������ ������ � ���������� ����� �� � ��). ������� � ������� ���� � ������� ������� ����� ������� ������������� ���� �������������. ������������ ��� ������� ���������� �� ���������� �������������� ������� �������� ���������.
������������ ���� ����������� �������� ���� �������� ������� �����, ��������� ������������� ����� � ������� (��������, ���� � �����), �������� ������ � ��������� ������ �������� (��������, ������� ������� ��������).', '������� ���'),
(7, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\EarlyMiddleAge.jpg', '������ �������������', '������ ����� ����� �����', '������ ������������� � ������ ����������� �������, ���������� ����� ������� �������� ������� �������. ������ ����� ����� �����, �������������� � 476 �� 1100 ���. � ����� ������� ������������� ��������� ������� ����������� �������, ��������� �������, �������� ����������� �������� � ������ � ��������� � ��������� � �� ����������� ����������� � ������������ ��������� �����������, � ������ ������ �������� ���������� ������� ����� �������� ������. �������� ������ � ������� ����� � ������ ��������� ��������, �� ���������� �������� ������������ ��������� ��������� ���������� ������, ������ � �������, ��������� ����������� � �����������, � ����� � ����������� � ��������� ������: ������� ������� � �������� ����.', '������� ����'),
(8, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\HighMiddleAge.jpg', '������� �������������', '�������������� XI�XIV ����', '��� ������������� ��� ��� ������ ������ ������� ��������. ���������� ����������� ��������� �������� �� ����� ������������ ��������� ����������� � ������. ����������� ��������� �����, ������������� ��� ����� ����, ��������� ����� ������, ����� ������� �������� �������� � ���������, ����� ����������� ����� ����������� �����������. ����������� �������� ������� �������� ��������, ��� ����, � ����� ���� ������������ ������. ������������ � ���� ������� ������������� ���� �������� ��������� �������, � ����� �������� ���������� �������� � ���������-������ �������. � ���� ������ �������������� ������� ����������� ������. ��������� ������������� ����� ������ (� ��� ����� � �������) ���������� ������ �� ��� �������� ����������� �������� �����. � �������� � ��������� ������ ������������ ����� ����������� �����, ��� ������, ��������, �����, ������, �������. ������������ �������� ��������� � ����� ����������� � �������� ������� � ������������ �����, ���� �������� ������ ������������.', '������� ����'),
(9, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\LateMiddleAge.jpg', '������� �������������', 'XIV�XV ����', '����� � �������� �������� ���� � XIV ���� ����� �������� ��������� ��������������� ���������� � ������. �������� ������������ ������ �������� � ����� ����� ��������� ����� ����� ������� � ��������. ������ ���� ��������, � �������� ��������� ������ � ������. ������������ ����� �� ������ �������� � ��� ����� ����������� �������������� �� 80%. ������ �������, �������� �������������, �����, ��� ��������������� ������� � ������� ������, ������ � ������. � �� �� �����, ���� ������ ������������� ������� ��������� � ���������� �����. � XIV ���� � ������ �������� ����������� �������� ��������, ��� ���������, ������� �������� ������������ ������ ����� �����. ����������� ��������� ��������� ������� ���������� ��������� ��� �������� ����������� ����� � ����������. ����� �������� ������� ���� ��������� ����� �������� ���� �, ���������� �����, � ������ ��������� ����������� �������� �������������� ���������� �� ���� ����.', '������� ����'),
(10, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Renessanse.jpg', '�����������', '��-������� ���������', '����� ���������� ��������� �������� ���������� ������������ ��������� ������������ ��������� � ������.
������ �������� � ����������� ����������� ����� ������� ������������� �����������, � �������� � ������ ����������, ������� � ����� ���� ���������� � ������������ ���������, ����������� ��������� �������� ����������, ����������� ������������� ������, � ����� ���������� ���������� �������� ��������, � �������� ������� �� ������������.
���� �������-��������� ����� � ����� ������� ��������, �� ������������� � ���������� ����������: �������� � �������������, ���������, ��������. ���� �� ���� ����� ������������� ������� ���������, ��������� �������������, �� ������ ��������� ���������, � � ����������, ��������� ���. ��� ������� � ��������� ��������� � �����������-������������ ��������, ���������������� ��������, ��� ��������, ��� �������, ��� ��������, ���������� ������������ ��� ������ �������� � �������� ������ ������������ ����������.
� ������� ����� ��������� �������� ������ ����� � ���������, ������������ ������� ���������� ��� �������� ������. ����� ������������� ���������� � ����������, ���� � ��� ������ ���������������, ������������ ���������. ����������� � �������� XV ���� �������������� ������� �������� ���� � ��������������� ��������� �������� � ����� �������� �� ���� ������.
����������� �������� � ������, ��� ������ ��� �������� ���� ������� ��� � XIII � XIV �����, �� ��� ����� ������������ ������ � 1420-� �����.', '����� �����'),
(11, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Reformation.jpg', '���������� � ���� ����������', '��� ����', '���������� ���������� ��������� ��������� � �������� ������. ���������� ������������ � 1520-� ����� �� ������ �������� XVII ����, ����� � ������������ �������� ���������������.
���������� ���� � �������� ������ ������ � ������� ���� ��������, ������� ������� � ������� ������-������. ���������� �� ������� �������� ������� �� �������� ���������, ���������� ���������� ������ ������ ��������� ����������. �������� �� ������� �������������� ������������. ������� ������������� �������������� � ��� ��� ���� ��������� ��� ��� ������� ����, ��� ����� ���������� ����������, ���� �� ���������� ����� ���� ����� �������, ��� ������� ׸���� ��������� � �� �����, ������� ������������� ����������. �� � ����� �� �������� ��������� �� �������� �������� ������������ ������.
� ���� ���������� ������������ ��� ��������� ������������ �������.
� �� ������ � � ������� ������ ���������������� �����������, � �������� �������� �����.
� ����������, ��������, ��������������� ��� ��������� �������� ������ � ����� ������, ������� ��������� ��������� � �������, ������� ���� ����������������� �������� ��������� �������� �� ������������ � ����������.
� �������, �� ����������� ���������� �������� �������� �������, ������� ���������� �������� �����������.
���������� ������� ������������ ������� �� �������� ��������� �����, �������� � ����������, ������� � ��������� ����� � �����������, �������� ����������� � �����������������. ��������� ���������� ���� ��������� ��������, ��������� � ������.', '����� �����'),
(12, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Contrreformation.jpg', '��������������� � ���� ����������', '��� ����', '�� ������ �������� XVI �. ������������ ������� ������ ������ �� �������������� ������� ������������. ��� �������� �������� �������� ���������������. ����� �� ������� ������ ������ � ����������� ���� ����� ��������, ��������� � 1534 �. � ������������ ����� ������� � 1540 �. ������������� ����� ������ ���� ���������� � ��� � 1569 �. ������� ��������� ��������������� ��� ������ ���� ������. ��������� �� ������������ �������� ������ ������� � ��������� III ����. ��� �������������� ���������� ������������ ������, �������� ������������ ������������ ���������� �������. � ���������� ����������� ��������������� ���������� ������������� ���������� � ������������ ������� ������������ ������, ��������� �������������� ��������. ����������� ��������������� � ���� ���������� ���� ���������� �� ������ ������ ��������������, �� � ������ �����������. � ������ ��������������� ��������� ����������� ������������ ������ �������� � ������� � ������������, ����������� �� ��������� ��������� ������ � 1569 �. ��������������� � ���� ���������� ���������� ������������ �� 30-� �. XVIII �.', '����� �����'),
(13, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Industriation.jpg', '����������������', '�������� ����', '���������������� � ������� ����������� ���������-�������������� �������� �� ������������� ����� �������� � ���������������, � ������������� ������������� ������������ � ���������. ���� ������� ������ � ��������� ����� ����������, �������� � ����� ��������, ��� ���������� � �����������. � ���� ���������������� �������� ����� ������������ ��������� ���������, �������� ��� ��������������. ���������� ��������� � ����� � ��������� �� ����������� ��� ����� ������� ������������ ����� ���������� � ������� �������� ����� ���� ����� � ���������� ���� ������������ � ������� ���������. � ���������� ���������� ��� ����� �������, � �������� �����, ������� ����� ��������� � ����� ���� �����, ��� � ���� ������� ����������� ���������� � ���������� ������������� ����.
���������������� � �������� �������, ���������� �������� ��������������, ������������ ���������� ���� �������������� � ���������.
����� � ����� ���������������� � ������ ������� ����� ���� �������������. ������ �������, ��� ��������� ������������ ���������, ����� �������������� (� �������� XIX ����). ������� ����� �������������� � ������ 20-� ����� XX ����. � ���������� ������� ���������������� �������� � ����� XIX � �� ������ XX ��. � ����� XX ���� ����� �� �������� ������������ �������� �������� ����� ��������� ����, � ����������� �������.', '�������� �����'),
(14, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Capitalism.jpg', '����������', '������������� �������', '���������� � ������������� ������� ������������ � �������������, ���������� �� ������� �������������, ����������� ��������� � ������� �������������������. ������� ��������� ��� �������� ������������� ������� �������� ���������� � ���������� ��������, � ��������� �������.
������� ����������� � ��� ������������� ����������, � ������� �������� ����������� ����� ��������� �� ����������� ����� � �������� � ��� ���� ��������� ����� ��������. �������� ��������� ���������� ����� ������� �� ������������ ������ �� ������� ������������� � �� ������������� ������ ������� �������������������. ������ � ��� ��� ���� ���� �������������� �������������� ����������� ����� � ��������� ����������; ��������������� �������������; ����������� �� �������� ����������, � ��� ����� ����������� �� ������� ������������ ��� ��������� ��������; ���������� �������; ��������������� ������� � �. �. ����� �� ��� �������� ��������� ���������� ����, ����� � ���������� �������� ������ �����������.
����������������� ���������� ����� �� ����� �������� ��������� � ���������������������� �����, ��������� � ���������� �����. �������� ���������� �������������� �����������, ������������ �������� � ����� ����� ������ ��� � �������� ������� �������������� ������� �� ��������� ����������, ������������ ������������ ����� ��������� ��������, �� ������ �������������� � ����� �������� ������������ �����, ������ ������ ������������ � ������ ������������� �������� ����������.', '�������� �����'),
(15, 'D:\University\coursach\MyLove\MyLove\DesignElements\Pictures\Globalization.jpg', '������������', '������� ����������', '������������ � ������� ��������� �������������, ������������, ���������� � ����������� ���������� � ����������.
������������ �������� ����������� ������ ��������� ��������� ��������� �������� ���������, ����������� ��� ������������ ������������ ��������, ��������� ���� � ������ �������� �������������� ���������� �����, ������������� � ������������ ���������, ���� ��������� � ������� ����� � ������� ������������ ��������� �� ������ ������������������� � ��������������. �� ���� ���� ���������� ������������ ������ ������� ������� �������� ��������� � ������������ � � ��������������, ���������� ������� ���������������� ������������, ������� �������� ������� ����������� ����� ������������� ��������� �� ���������� ������ �����. ������� ������������ ���� ��������� �������� �������������� ����������� �������� ������.
�������� ���������� ����� �������� ������� ���������� �����, �������� (�, ��� �������, ������������) � ��������� ���� ������� ��������, ������� ����, ���������������� ��������, �������������� ����������������, ������������� � ��������������� ���������, � ����� ��������� � ������� ������� ������ �����. ��� ����������� �������, ������� ����� ��������� ��������, �� ���� ���������� ��� ����� ����� ��������. � ���������� ������������ ��� ���������� ����� ��������� � ����� ��������� �� ���� ��� ���������. ���������� ��� ���������� ���������� ����� ��� ������ ���������� �������, ��� � ���������� ����� � ����� ��������������� ���������.', '�������� �����')