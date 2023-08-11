# Hướng dẫn sử dụng OpcodeGuide
## Giới thiệu
OpcodeGuide là một công cụ hình ảnh để tạo tập tin OPCODE được sử dụng trong LucaSystemTools để xuất tập lệnh.
## Giải thích giao diện
![](./../pic/s1.png)
Sau khi load file:
![](./../pic/s2.png)
## Bắt đầu nhanh

1. File->New/Open Opcode打开或新建一个OPCODE  
    新建时，需要先选择**游戏引擎的版本号**，具体版本号可根据发售日期和平台推测
2. File->Open Script选择解压后的游戏脚本文件夹  
    注：此文件夹中必须**只能含脚本**文件，不能包含其他无关文件
3. 选择左侧"**脚本文件列表**"中的文件名，点击"**脚本控制**"中的"**载入脚本**"按钮，即可载入脚本
4. 打开脚本后自动载入第一句脚本，使用“**解析下一句**”到需要修改的语句
5. 在下方字节预览窗口中选择字节，“**数据预览**”中会显示对应的值
6. 选择“**可选类型**”中的可用类型，“**向上插入**”或“**向下插入**”到“**参数类型列表**”中
7. 点击“**应用此条**”，即可在下方预览编辑框中看到解析的效果
    如果有问题，点击“**脚本控制**”中的“**重载**”即可还原
    如果无问题，点击“**应用全局**”即可重载此脚本，若出错，则可能需要在插入类型时勾选“**可空**”
9. File->Save/Save As保存已经“**应用全局**”的OPCODE
9. 使用此OPCODE.txt，配合LucaSystemTools即可导出需要数据

1. File->New/Open Opcode để mở hoặc tạo mới một tập tin OPCODE
    Khi tạo mới, bạn cần chọn số phiên bản của game engine, phiên bản cụ thể có thể được suy luận dựa trên ngày phát hành và nền tảng.
2. File->Open Script để chọn thư mục chứa tập lệnh của trò chơi sau khi đã giải nén
    Lưu ý: Thư mục này chỉ được chứa các tập tin tập lệnh, không thể có các tệp không liên quan khác.
3. Chọn tên tập tin trong danh sách "Danh sách tập lệnh" bên trái, sau đó nhấn nút "Tải tập lệnh" trong phần "Kiểm soát tập lệnh" để tải tập lệnh.
4. Sau khi mở tập lệnh, tập lệnh đầu tiên sẽ được tải tự động. Sử dụng nút "Phân tích câu lệnh tiếp theo" để chuyển đến câu lệnh cần chỉnh sửa.
5. Chọn các byte trong cửa sổ xem trước byte phía dưới, giá trị tương ứng sẽ hiển thị trong phần "Xem trước dữ liệu".
6. Chọn các loại có sẵn trong phần "Loại có thể chọn", nhấn nút "Chèn lên" hoặc "Chèn xuống" để thêm vào phần "Danh sách loại tham số".
7. Nhấn nút "Áp dụng dòng này" để xem hiệu ứng phân tích trong hộp sửa đổi dưới cùng.
    Nếu gặp vấn đề, nhấn nút "Tải lại" trong phần "Kiểm soát tập lệnh" để khôi phục.
    Nếu không có vấn đề gì, nhấn nút "Áp dụng toàn cục" để tải lại tập lệnh này, nếu xảy ra lỗi, có thể cần kiểm tra tùy chọn "Có thể là rỗng" khi chèn loại tham số.
8. File->Save/Save As để lưu tập tin OPCODE đã được "Áp dụng toàn cục".
9. Sử dụng tập tin OPCODE.txt này cùng với LucaSystemTools để xuất dữ liệu cần thiết.