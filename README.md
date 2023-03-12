# CNPM_QuanLyQuanCafe
1.1	Mô tả hoạt động hệ thống
Một cửa hàng coffee cần xây dựng hệ thống quản lý: Các công việc chính được thực hiện bởi nhân viên quản lý. Nhân viên được phân công vào các ca trực thực hiện các công việc như gọi món, chuyển bàn… Hoạt động chính của nhân viên quản lý bao gồm: quản lý doanh thu, quản lý báo cáo hoạt động của quán, quản lý tài khoản, quản lý danh sách món...
-	Một quán coffee sẽ bao gồm nhiều bàn (mã số bàn)
-	Một quán coffee sẽ có nhiều loại đồ ăn – thức uống khác nhau và được ghi vào trong menu bao gồm: danh mục, tên món, mã số, đơn giá.
-	Khi khách đến quán, khách sẽ gọi món theo menu có sẵn và được nhân viên phục vụ ghi lại yêu cầu. Nhân viên có trách nhiệm nhập danh sách này vào máy. Nếu khách có yêu cầu thêm món thì nhân viên phải cập nhật vào hóa đơn của bàn đó.
-	Nhân viên phục vụ có nhiệm vụ đối chiếu với danh sách yêu cầu của bàn để gửi món ăn cho khách
-	Bàn nào đã có khách hàng hệ thống để thông báo cho nhân viên để tránh bị trùng bàn. Nếu khách có nhu cầu đổi bàn mọi thông tin món của khách sẽ được chuyển qua bàn khác
 
1.2	Mô tả chức năng chi tiết quán coffee
-	Bán hàng: Khi khách vào quán sẽ được bộ phận phục vụ gửi menu để khách lựa chọn đồ ăn – thức uống. Nhân viên thu ngân sẽ thống kê số lượng khách yêu cầu để cho khách thanh toán. Khách sẽ thanh toán với bộ phận thu ngân. Bộ phận thu ngân sẽ lưu dữ liệu vào máy tính để theo dõi hằng ngày.
-	Tạo hóa đơn nhập: Dựa vào số lượng hàng mà các đại lí cung cấp thì bộ phận pha chế sẽ viết hóa đơn nhập hàng cho các đại lí để các đại lí yêu cầu bộ phận kế toán thanh toán tiền hàng.
-	Yêu cầu đồ ăn – thức uống: dựa vào menu của quán, khách sẽ gọi đồ ăn – thức uống theo nhu cầu của mình và được bộ phận thu ngân lưu vào hệ thống.
-	Thanh toán hóa đơn: dựa vào thông tin yêu cầu đồ ăn – thức uống mà khách đã gọi để tiến hành thống kê và thanh toán. Sau khi thanh toán, nhân viên sẽ gửi số bàn cho khách ngồi chờ
1.3	Các chức năng hệ thống
Sau quá trình khảo sát tại hai đểm quán coffee A và B các hệ thống yêu cầu
-	Quán A: 
+  	Yêu cầu phần mềm quản lý được sô lượng bàn và linh hoạt trong việc kiểm soát  tình trạng bàn, số lượng bàn.
+	Tùy chỉnh dễ dàng danh sách các món. Thuận tiện cho việc oder.
+ 	Tổng hợp được doanh thu.
-	Quán B:
+	Phân cấp được quản lý và nhân viên trong ca trực
+ 	Đáp ứng được các yêu cầu cơ bản của việc quản lý oder, quản lý bàn, quản lý món.
+	Xuất hóa đơn cho khách hàng sau khi thanh toán
Tổng kết:
	 Sau quá trình khảo sát, nhóm đã thống nhất và xem xét các phương án thiết kế và xây dựng phần mềm chốt lại được các yêu cầu  sau:
1.	Phần mềm phải có khả năng phân quyền tài khoản
2.	Giao diện thân thiện, dễ sử dụng
3.	Chủ đề ứng dụng dễ dàng thay đổi tùy biến
4.	Đảm bảo an toàn bảo mật
5.	Dễ dàng quản lý danh sách món 
6.	Quản lý hóa đơn   
7.	Quản lý, thống kê  doanh thu
8.	Quản lý tình trạng bàn 
9.	Dễ dàng cài đặt và sử dụng
10.	Tương thích tốt với nhiều hệ thống, chi phí đầu tư thấp
1.4	Công cụ dùng để phát triển ứng dụng
Công cụ phân tích: UML, Case studio 2
Thiết kế CSDL: Hệ quản trị SQL server
Công cụ lập trình: C# trên môi trường VisualStudio 2019
Kỹ thuật: SqlCommand Class (System.Data.SqlClient), sử dụng mô hình client & sever để quản hý hệ thống cơ sở dữ liệu
3.1	Đăng nhập, phân cấp tài khoản
- 	Để đảm bảo an toàn thông tin trong quá trình quản lý hệ thống, chức năng phân quyền Admin và user sẽ giúp phân cấp hệ thống. Admin sẽ có quyền cao nhất trong hệ thống, có thể thêm hoặc xóa sửa các user, các bàn ăn, thêm xóa sửa danh sách món ăn, thống kê doanh thu của quán. Các user sau khi được admin thêm vào chỉ có chức năng quản lý quán coffee. Từ đó đảm bảo trong việc quản lý được an toàn và dễ dàng hơn.
-	Tài khoản khi được tạo sẽ chọn loại tài khoản 1-Admin và 0-User. Có thể tạo không giới hạn số tài khoản admin và user tuy nhiên trong lúc đăng nhập trong phiên làm việc chỉ được đăng nhập bằng một tài khoản admin.
3.2	Giao diện quản oder
-	Chương trình quản lý chính của quán coffee sẽ bao gồm quản lý bàn còn trống, quản lý danh sách món đã gọi của bàn, quản lý hóa đơn của bàn.
- 	Ngoài ra còn có thể chuyển tất cả thông tin qua các bàn còn trống khác để khách hàng có thể chuyển bàn.
- 	Những bàn còn trống hay có người sẽ được kí hiệu bằng màu khác nhau để nhân viên có thể dễ dàng trong việc quản lý, sắp xếp bàn ăn để phục vụ khách hàng.
-	Khi khách hàng gọi món, nhân viên sẽ nhập danh sách các món ăn từ menu có sẵn, trong menu có giá tiền của món ăn có thể nhập số lượng món ăn cho bàn, hệ thống sẽ tự động tính ra tổng tiền hóa đơn mà khách hàng phải trả. Khách hàng có thể sử dụng các mã giảm giá. 
-	Sau khi khách hàng thanh toán hệ thống sẽ xuất hóa đơn và lưu lịch sử hóa đơn vào cơ sở dữ liệu để thống kê doanh thu
-	Ngoài ra người dùng có thể chọn mục home để có thể oder cho những khách mang về)
Người dùng Admin tại đây có thể mở tab admin để quản lý những chức năng chuyên sâu như thêm, xóa, sủa người dùng, bàn ăn còn đối với loại tài khoản user chức năng này sẽ bị ẩn đi và chỉ có thể chỉ sửa thông tin tài khoản của chính mình. 
