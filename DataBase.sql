USE master
GO

IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = 'QuanLyDoXe'
)
DROP DATABASE QuanLyDoXe
GO

CREATE DATABASE QuanLyDoXe
GO

use QuanLyDoXe
go

----------TAO BANG
create table XE
(
	BienSo		varchar(15)		not null,
	ThoiGian	datetime		not null	default getdate(),
	constraint	pk_xe primary key(BienSo)
)

create table DOANHTHU	
(
	Nam			int				not null	default year(getdate()),
	Thang		int				not null	default month(getdate()),
	SoTien		int				not null	default 0,
	constraint	pk_dt primary key(Nam, Thang)
)

create table VIP
(
	BienSo		varchar(15)		not null,
	HoTen		nvarchar(50)	not null,
	SDT			varchar(15)		not null,
	NgayDK		date			not null	default getdate(),
	NgayHH		date			default getdate(),
	constraint pk_vip primary key(BienSo)
)

create table DONGTIEN
(
	BienSo		varchar(15)		not null,
	NgayDong	smalldatetime	not null	default getdate(),
	SoThang		int				not null,
	constraint pk_dti primary key(BienSo, NgayDong)
)

create table LOGG
(
	ThoiGian	datetime		not null	default getdate(),
	ThongTin	nvarchar(200)	not null,
)

create table THAMSO
(
    MocTien1    int                not null    default 3000,
    MocTien2    int                not null    default 6000,
    TienVIP        int                not null    default 150000,
    TienCocVIP    int                not null    default 200000,
    MocTG1        int                not null    default 5,
    MocTG2        int                not null    default 14,
    MocTG3        int                not null    default 22,
)
go

----------TAO KHOA NGOAI
alter table DONGTIEN add constraint fk_dt_vip foreign key(BienSo) references VIP(BienSo)
insert into THAMSO default values
go

/*
	PD them XE 
	return 1 vao @out : thanh cong
	return 0 vao @out : khong thanh cong
*/
create procedure PDInsertXE
	@BienSo		varchar(15),
	@out		int = NULL output
as
begin
	if not exists
		(
			select *
			from XE
			where BienSo = @BienSo
		)
	begin
		INSERT INTO XE (BienSo)
		VALUES (@BienSo);
		return 1
	end
	else 
		return 0
end
go

/*
	PD tim XE 
*/
create procedure PDFindXE
	@BienSo		varchar(15)
as
begin
	select *
	from XE
	where BienSo like '%' + @BienSo + '%'
end
go

/*
	PD load thong tin xe
*/
create procedure PDLoadXe
as
begin
	select * from XE
end
go

/*
	PD xoa XE 
	return 1 vao @out : thanh cong
	return 0 vao @out : khong thanh cong
*/
create procedure PDDeleteXE
	@BienSo		varchar(15),
	@out		int = NULL output
as
begin
	if exists
		(
			select *
			from XE
			where BienSo = @BienSo
		)
	begin
		delete XE 
		where BienSo = @BienSo;
		return 1
	end
	else 
		return 0
end
go

/*
	PD sua XE 
	@BienSoFind : Bien so can sua
	@BienSoUpdate : Bien so sua
	return 1 vao @out : thanh cong
	return 0 vao @out : khong thanh cong
*/
create procedure PDUpdateXE
	@BienSoFind			varchar(15),
	@BienSoUpdate		varchar(15),
	@out				int = NULL output
as
begin
	if exists
		(
			select *
			from XE
			where BienSo = @BienSoFind
		)
	begin
		update XE 
		set BienSo = @BienSoUpdate
		where BienSo = @BienSoFind
		return 1
	end
	else 
		return 0
end
go

/*
	PD them DOANH THU	 
	return 1 vao @out : thanh cong
	return 0 vao @out : khong thanh cong
*/

create procedure PDInsertDOANHTHU
	@out				int = NULL output
as
begin
	if not exists
		(
			select *
			from DOANHTHU
			where Nam = year(getdate()) and Thang = month(getdate())
		)
	begin
		INSERT INTO DOANHTHU DEFAULT VALUES;
		return 1
	end
	else 
		return 0
end
go

/*
	PD them DOANHTHU
	@Tien : So tien can them
	Tu dong them doanh thu moi neu thang nay chua co
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDUpdateDOANHTHU
	@Tien		int,
	@out		int = NULL output
as
begin
	if exists
		(
			select *
			from DOANHTHU
			where Nam = year(getdate()) and Thang = month(getdate())
		)
	begin
		update DOANHTHU
		set SoTien = SoTien + @Tien 
		where Nam = year(getdate()) and Thang = month(getdate())
		return 1
	end
	else 
	begin
		declare @res int
		exec @res = PDInsertDOANHTHU
		exec @res = PDUpdateDOANHTHU @Tien
		return @res
	end
end
go

create procedure PDDeleteDOANHTHU
	@Tien		int,
	@out		int = NULL output
as
begin
	if exists
		(
			select *
			from DOANHTHU
			where Nam = year(getdate()) and Thang = month(getdate())
		)
	begin
		update DOANHTHU
		set SoTien = SoTien - @Tien 
		where Nam = year(getdate()) and Thang = month(getdate())
		return 1
	end
	else 
	begin
		declare @res int
		exec @res = PDInsertDOANHTHU
		exec @res = PDUpdateDOANHTHU @Tien
		return @res
	end
end
go

/*
	PD them VIP
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDInsertVIP
	@BienSo		varchar(15)		,
	@HoTen		nvarchar(50)	,
	@SDT		varchar(15)		,
	@out		int = NULL output
as
begin
	if not exists
		(
			select *
			from VIP
			where BienSo = @BienSo
		)
	begin
		insert into VIP(BienSo, HoTen, SDT) 
		values (@BienSo, @HoTen, @SDT);
		return 1
	end
	else 
		return 0
end
go



/*
	PD sua VIP
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDUpdateVIP
	@BienSoFind			varchar(15)		,
	@HoTen				nvarchar(50)	,
	@SDT				varchar(15)		,
	@out				int = NULL output
as
declare @NgayUpdate date 
select @NgayUpdate = getdate()
begin
	if exists
		(
			select *
			from VIP
			where BienSo = @BienSoFind
		)
	begin
		update VIP 
		set HoTen	= @HoTen,
			SDT		= @SDT,
			NgayDK = @NgayUpdate
		where BienSo = @BienSoFind
		return 1
	end
	else 
		return 0
end
go

/*
	PD xoa VIP
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDDeleteVIP
	@BienSo		varchar(15),
	@out		int = NULL output
as
begin
	if exists
		(
			select *
			from VIP
			where BienSo = @BienSo
		)
	begin
		delete VIP 
		where BienSo = @BienSo;
		return 1
	end
	else 
		return 0
end
go

/*
	Them LOGG
*/
create procedure PDInsertLOGG
    @ThongTin	nvarchar(200)
as
begin
	insert into LOGG(ThongTin) values(@ThongTin)
end
go

/*
	Lay Logg trong 2 moc thoi gian
*/
create procedure PDGetLOGG
    @First		smalldatetime,
	@Second		smalldatetime
as
begin
	select *
	from LOGG
	where ThoiGian between @first and @second
end
go

/*
	PD Them DONGTIEN
		return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDInsertDONGTIEN
	@BienSo		varchar(15)	,
	@SoThang	int			,
	@output		int = NULL output
as
begin
	if exists
	(
		select * from VIP
		where BienSo = @BienSo
	)
	and not exists
	(
		select * from DONGTIEN
		where BienSo = @BienSo
	)begin
		insert into DONGTIEN (BienSo, SoThang) values (@BienSo, @SoThang)
		update VIP 
		set NgayHH = DATEADD(day, 30 * @SoThang, NgayHH)
		where BienSo = @BienSo 
		return 1
	end
	else 
	begin
		return 0
	end
end
go

/*
	PD xoa DONGTIEN
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDDeleteDONGTIEN
	@BienSo		varchar(15)	,
	@output		int = NULL output
as
begin
	if exists
	(
		select * from DONGTIEN
		where BienSo = @BienSo
	)begin
		delete from DONGTIEN where BienSo = @BienSo
		return 1
	end
	else 
	begin
		return 0
	end
end
go

/*
	PD them DONGTIEN
	return 1 vao @out: thanh cong
	return 0 voa @out: khong thanh cong
*/
create procedure PDUpdateDONGTIEN
	@BienSo		varchar(15)	,
	@SoThang	int			,
	@output		int = NULL output
as
begin
	if exists
	(
		select * from DONGTIEN
		where BienSo = @BienSo
	)begin
		update DONGTIEN
		set SoThang = SoThang + @SoThang
		where BienSo = @BienSo
		update VIP 
		set NgayHH = DATEADD(day, 30 * @SoThang, NgayHH)
		where BienSo = @BienSo 

		return 1
	end
	else 
	begin
		return 0
	end
end
go

/*
CapNhat THAMSO
*/
create procedure PDUpdateTHAMSO
    @MocTien1        int    ,
    @MocTien2        int    ,
    @TienVIP        int    ,
    @TienCocVIP        int    ,
    @MocTG1        int    ,
    @MocTG2        int    ,
    @MocTG3        int    

as
begin
    update THAMSO
    set MocTien1 = @MocTien1, 
        MocTien2 = @MocTien2, 
        TienVIP = @TienVIP, 
        TienCocVIP = @TienCocVIP,
        MocTG1 = @MocTG1,
        MocTG2 = @MocTG2,
        MocTG3 = @MocTG3   

end
go

create procedure PDDeleteExpiredXe
	@output		int = NULL output
as
begin
	declare @cnt int = 0;

	delete from DONGTIEN
	where BienSo in (
		select BienSo from VIP
		where CONVERT(date, NgayHH) < GETDATE()
	)

	set @cnt = @@ROWCOUNT

	update VIP
	set NgayHH = GETDATE(), NgayDK = GETDATE()
	where CONVERT(date, NgayHH) < GETDATE()

	if (@cnt = 0 )
		return 0
	return 1
end
go

exec PDDeleteExpiredXe
select * from DONGTIEN

-----------XE--------------
insert into XE values ('69E-336.69', '5/27/2023 6:48:53') 
insert into XE values ('52M-577.52', '6/1/2023 10:8:41')
insert into XE values ('28P-749.28', '1/11/2023 2:32:5')
insert into XE values ('37U-530.37', '4/28/2023 16:24:45')
insert into XE values ('8U-354.8', '2/10/2023 7:4:34')
insert into XE values ('35G-123.35', '1/26/2023 11:52:48')
insert into XE values ('57V-603.57', '2/14/2023 21:4:53')
insert into XE values ('26Q-272.26', '2/4/2023 1:8:12') 
insert into XE values ('26I-927.26', '1/22/2023 19:10:37')
insert into XE values ('58J-300.58', '3/16/2023 2:36:45')
insert into XE values ('26T-370.26', '3/25/2023 19:40:7')
insert into XE values ('54O-378.54', '3/1/2023 13:9:22')
insert into XE values ('5M-270.5', '1/15/2023 6:46:30')
insert into XE values ('31X-741.31', '6/11/2023 12:28:33')
insert into XE values ('87L-739.87', '5/1/2023 13:24:26') 
insert into XE values ('69W-601.69', '5/22/2023 6:54:42')
insert into XE values ('80C-47.80', '2/20/2023 14:32:12')
insert into XE values ('24T-680.24', '4/11/2023 9:14:1')
insert into XE values ('38M-826.38', '5/21/2023 6:32:52')
insert into XE values ('14X-882.14', '4/8/2023 20:12:58')

----------DOANHTHU---------------------
insert into DOANHTHU values (2023, 1, 3885000)
insert into DOANHTHU values (2023, 2, 2422000)
insert into DOANHTHU values (2023, 3, 7535000)
insert into DOANHTHU values (2023, 4, 3961000)
insert into DOANHTHU values (2023, 5, 2190000)
insert into DOANHTHU values (2023, 6, 284000)

-----------VIP-------------------
insert into VIP values ('98K-689.98', 'Nguyen Quoc C', '0461376424', '2/21/2023 3:16:39', '5/21/2023 3:16:39') 
insert into VIP values ('79Q-630.79', 'Hoang Quy Q', '0443360695', '2/16/2023 4:8:45', '3/16/2023 4:8:45')
insert into VIP values ('91S-926.91', 'Ly Quoc F', '0560384724', '5/2/2023 2:49:20', '11/2/2023 2:49:20')
insert into VIP values ('59L-856.59', 'Nguyen Van M', '0377369816', '4/28/2023 1:52:50', '10/28/2023 1:52:50') 
insert into VIP values ('15I-665.15', 'Ly Quoc F', '0626373873', '7/14/2023 20:56:22', '10/14/2023 20:56:22')
insert into VIP values ('62S-224.62', 'Nguyen Quy P', '0521371563', '1/25/2023 7:39:45', '2/25/2023 7:39:45')
insert into VIP values ('40L-829.40', 'Nguyen Van P', '0530359163', '1/18/2023 17:26:17', '3/18/2023 17:26:17') 
insert into VIP values ('26Z-396.26', 'Hoang Van O', '0443362499', '5/25/2023 10:1:32', '8/25/2023 10:1:32')
insert into VIP values ('67O-807.67', 'Hoang Van W', '0545385475', '11/27/2023 13:9:21', '12/27/2023 13:9:21')
insert into VIP values ('62D-972.62', 'Nguyen Van D', '0359370781', '11/25/2023 20:12:37', '3/25/2024 20:12:37')

----------DONGTIEN----------------
insert into DONGTIEN values ('98K-689.98', '2/21/2023 3:16:39', 3)
insert into DONGTIEN values ('79Q-630.79', '2/16/2023 4:8:45', 1)
insert into DONGTIEN values ('91S-926.91', '5/2/2023 2:49:20', 6)
insert into DONGTIEN values ('59L-856.59', '4/28/2023 1:52:50', 6)
insert into DONGTIEN values ('15I-665.15', '7/14/2023 20:56:22', 3)
insert into DONGTIEN values ('62S-224.62', '1/25/2023 7:39:45', 1)
insert into DONGTIEN values ('40L-829.40', '1/18/2023 17:26:17', 2)
insert into DONGTIEN values ('26Z-396.26', '5/25/2023 10:1:32', 3)
insert into DONGTIEN values ('67O-807.67', '11/27/2023 13:9:21', 1)
insert into DONGTIEN values ('62D-972.62', '11/25/2023 20:12:37', 4)


-------------------------------------------------Cac lenh lien quan----------------------------
----Xem dang bat hay tat----
select name,
	CASE
		WHEN OBJECTPROPERTY(object_id, 'ExecIsTriggerDisabled') = 1 THEN 'Disabled'
		ELSE 'Enabled'
	END AS Status
FROM sys.procedures

----Bat/Tat khoa----
EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'
EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT all'
