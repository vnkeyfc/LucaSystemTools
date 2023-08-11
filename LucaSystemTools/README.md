# Hướng dẫn sử dụng OpcodeGuide
## Giới thiệu
OpcodeGuide là một công cụ hình ảnh để tạo tập tin OPCODE được sử dụng trong LucaSystemTools để xuất tập lệnh.
## Giải thích giao diện
![anh1](./../pic/s1.png)
* 1. Sau khi mở hoặc tạo mới OPCODE, phần này sẽ hiển thị tên của tất cả các hướng dẫn thao tác.
* 2. Sau khi mở folder chứa file script, phần này sẽ hiển thị danh sách các file.
* 3. Sau khi chọn file script và nhấp vào "Loadsript", sẽ hiển thị một số thông tin về script. Phía bên phải có thể thấy Số lượng câu lệnh: 0 điều khiển vị trí của các câu lệnh trong script hiện tại.
* 4. Chọn hướng dẫn, phần này sẽ hiển thị định dạng văn bản của hướng dẫn này.
Sau khi load file:

![anh2](./../pic/s2.png)
* 1. Danh sách tham số OPCODE hiện đang được phân tích từ câu lệnh này có thể được sửa đổi bằng cách sử dụng các nút "Insert" và "Delete" bên phải, hoặc bạn có thể kéo và thả để sắp xếp. 
    Bấm vào các tham số sẽ làm nổi bật các byte tương ứng trong khu vực byte ở phía dưới.
* 2. Bạn có thể viết danh sách kiểu trực tiếp dưới dạng chuỗi, nhấp vào "Parse to list"(phân tích thành danh sách) để chuyển đổi thành danh sách. Không phân biệt hoa thường, khoảng trắng không ảnh hưởng, sử dụng dấu phẩy tiếng Anh để tách biệt ↓
* 3. Các byte bắt đầu từ vị trí mà được nhấp trong khu vực dưới được phân tích thành giá trị kiểu "chuỗi" chỉ khi bạn chọn nhiều lựa chọn mới hiển thị xem trước.
* 4.
    * Khi nhấp vào "List of parameter types", sẽ hiển thị xem trước cho câu lệnh này.
    * Khi nhấp vào "Optional types", sẽ hiển thị thông tin về kiểu dữ liệu tương ứng.
    * Khi nhấp vào mục "String...." trong "Data preview", sẽ hiển thị nội dung tương ứng.
    * ← Vị trí của byte được chọn hiện tại trong tệp script, độ dài được chọn.

## Bắt đầu nhanh
1. File->New/Open Opcode để mở hoặc tạo mới một tập tin OPCODE
    Khi tạo mới, bạn cần chọn **phiên bản của game engine**, phiên bản cụ thể có thể được suy luận dựa trên ngày phát hành và nền tảng.
2. File->Open Script để chọn thư mục chứa tập lệnh của trò chơi sau khi đã giải nén
    Lưu ý: Thư mục này **chỉ được chứa các file script**, không thể có các file không liên quan khác.
3. Chọn tên file trong "**Script List**" bên trái, sau đó nhấn nút "**Load Script**" trong phần "**Script Control**" để load script.
4. Sau khi mở script, tập lệnh đầu tiên sẽ được tải tự động. Sử dụng nút "**Parse the next sentence**" (phân tích câu lệnh tiếp theo) để chuyển đến câu lệnh cần chỉnh sửa.
5. Chọn các byte trong cửa sổ xem trước byte phía dưới, giá trị tương ứng sẽ hiển thị trong phần "**Data preview**" (Xem trước dữ liệu).
6. Chọn các loại có sẵn trong phần "**Optional types**", nhấn nút "**Insert up**" hoặc "**Insert down**" để thêm vào phần "**List of parameter types**".
7. Nhấn nút "**Apply this**", bạn sẽ thấy kết quả phân tích trong ô chỉnh sửa xem trước ở phía dưới.
    Nếu gặp vấn đề, nhấn nút "**Overload**" trong phần "**Script control**" để khôi phục.
    Nếu không có vấn đề gì, nhấn nút "**Apply global**" để load lại script này, nếu xảy ra lỗi, có thể cần kiểm tra tùy chọn "**Nullable**" khi chèn loại tham số.
8. File->Save/Save As để lưu file OPCODE đã được "**Apply global**".
9. Sử dụng file OPCODE.txt này cùng với LucaSystemTools để xuất dữ liệu cần thiết.