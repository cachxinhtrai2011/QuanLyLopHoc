# QuanLyLopHoc
- Đối với dev:
	Download thư mục về chạy file MamNonBK.sql, nhớ sửa lại đường dẫn đến thư mục data của SQL Server 

	Mở file TruongMamNonBK.sln bằng visual, ở 2 project là GUI và Model các bạn tìm đến file App.Config và sử lại Connection đến database của các bạn

	<connectionStrings>
	<add name="MamNonBK" connectionString="metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=MamNonBK;persist security info=True;user id=sa;password=123abc;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" /> </connectionStrings>
	Xong xuôi Set as starup project GUI rồi Run Chương Trình

	tài khoản mặc định là: thuandt

	password: 123abc


- Đối với user:
	Bước 1: Click double vào file SetupData.bat để cài đặt CSDL vào trong máy
	Bước 2: Vào thư mục debug, click double vào file Setup1.msi để cài đặt
	Bước 3: Enjoy cái momment này

	tài khoản mặc định là: thuandt

	password: 123abc
