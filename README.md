# (VIỆT HÓA LẠI)
# MỘT SỐ CHỨC NĂNG ĐÃ ĐƯỢC TRIỂN KHAI TRONG DỰ ÁN [LuckSystem](https://github.com/wetor/LuckSystem) MỚI
# DỰ ÁN NÀY SẼ ÍT ĐƯỢC CẬP NHẬT SAU NÀY

## LucaSystemTools
Prototype's galgame tools


## FILE

Code extract liên quan đến hình ảnh viết bởi [deqxj00](https://github.com/wetor/LucaSystemTools/commits?author=deqxj00) code script do tôi (wetor) viết，CZ0 và Pak cùng một số code được lấy từ [LucaSystem](https://github.com/marcussacana/LucaSystem)。

Giải thích về cấu trúc hình ảnh có thể tìm hiểu thêm thông qua @DeQxJ00

Liên quan đến code script của game sử dụng cùng engine AIR, có thể tìm hiểu thêm thông qua @develseed

Liên quan đến code script của hai game NS, chỉ cần đọc code là có thể hiểu~

**PakTools.cs**

- Công cụ giải nén tập tin pak cho engine này

**CZ0Parser.cs、CZ1Parser.cs、CZ3Parser.cs、CZ4Parser.cs**

- Dường như các game mới của Prototype đều sử dụng loại hình ảnh này, phiên bản nâng cấp của dat. Hoàn thành việc trích xuất và đóng gói cho CZ1, chỉ có trích xuất cho CZ3, thêm mới CZ4.
- Trong CZ, việc nén màu từ 32 bit xuống 8 bit sử dụng công cụ pngquant https://github.com/kornelski/pngquant

**DatParser.cs**

- Chương trình trích xuất hầu hết các hình ảnh của Psv air, tương thích với cùng engine. Để đóng gói cụ thể, xin xem [PSV AIR 汉化工具](https://github.com/YuriSizuku/GalgameReverse/blob/master/prototype/prot_dat.py)

**FontInfoParser.cs**

- Giải mã tệp info của phông chữ island, tương thích với cùng engine, được thực hiện bởi DeQxJ00 [CZ1和info解析](https://tieba.baidu.com/p/6033002424)

**PsbScript.cs**

- Giải mã cơ bản cho tập lệnh air, có thể áp dụng cho Clannad trên Psv. Những lệnh có đuôi A3 A4 là lệnh chuyển hướng, không viết ở đây, chi tiết [PSV AIR 汉化工具](https://github.com/YuriSizuku/GalgameReverse/blob/master/prototype/airpsv_text.py)

**Script\*\*\*\*\.cs**

- Phân tích cơ bản cho tập lệnh, hỗ trợ chỉnh sửa và hợp ngược trở lại. Thử nghiệm không có vấn đề về tăng kích thước văn bản hay điều kiện nhảy.
- Có thể xuất ra dưới dạng json, lua, txt (lua không thể thực thi).

**Hỗ trợ tích hợp sẵn cho các game.**
>- 《Summer Pocket》Nintendo Switch  
>- 《Clannad》Nintendo （Opcode未完善）  
>- 《Tomoyo After Its a Wonderful Life CS Edition》Nintendo Switch  
>- 《Flowers - Shiki》  
>- 《Flowers 春》PSVita  
>- 《ISLAND》Psvita  
>- ...

- Hỗ trợ thêm tập tin Opcode tùy chỉnh mới, các Opcode và danh sách tham số khác nhau cho các trò chơi khác nhau. Theo lý thuyết, hỗ trợ hầu hết các trò chơi sử dụng LucaSystem engine trên hầu hết PSV và NS.

## Có thể làm gì

- Việc dịch đầy đủ cho phiên bản NS của Summer Pocket, Tomoyo After Its a Wonderful Life, Flowers - Shiki không còn vấn đề gì, còn đối với phiên bản NS của Clannad thì cần chỉnh sửa giải thích opcode.

- Lý thuyết trên NS, hầu hết các trò chơi prototype đều có thể dịch, tuy nhiên cần thực hiện một số thao tác để lấy danh sách opcode tương ứng cho từng trò chơi.

- Đối với các trò chơi prototype trên psv và cùng thời kỳ với air, miễn là cấu trúc tệp tương tự, hình ảnh cơ bản đều có thể trích xuất,

- Tóm lại, trò chơi clannad air rewrite trên psv cùng một loại, còn các dòng trò chơi island flowers trên psv là một loại khác, trong trường hợp gặp các trò chơi cùng engine, bạn có thể tham khảo.

- Hỗ trợ biên dịch và giải dịch kịch bản ISLAND trên psv.

- Nếu gặp vấn đề về việc hỗ trợ các trò chơi trên **nền tảng PSV và NS, sử dụng engine này**, bạn có thể gửi phản hồi qua việc nộp các vấn đề (issues).
## Hướng dẫn sử dụng
```
Options:
  -t|--file-type <FILE_TYPE>                    FileType [cz0] [cz1] [cz3] [cz4] [dat] [pak] [psb] [info] [scr]
  -m|--parser-mode <PARSER_MODE>                ParserMode [import] or [export]
  -f|--file-name <FILE_NAME>                    FileName or FolderName
  -o|--out-file-name <OUT_FILE_NAME>            OutFileName or OutFolderName
  -opcode|--opcode-path <OPCODE_PATH>           Script opcode ,For [scr]
  -c|--custom-opcode-path <CUSTOM_OPCODE_PATH>  Script custom opcode ,For [scr]
  -tbl|--tblfile <TBLFILE>                      TBL filename ,For [scr]
  -p|--pak-coding <PAK_CODING>                  Pakfile name coding ,For [pak]
  -lua|--format-lua                             Export and import lua format script (Can import) ,For [scr]
  -luae|--format-lua-export                     Export lua format script (Without param type, can't import) ,For [scr]
  -json|--format-json                           Export and import json format script (Import priority json) ,For [scr]
  -old|--format-old                             Use old format export and import ,For [scr]
  -d|--debug                                    Enable debug mode
  -l|--game-list                                Show list of supported games
  -oh|--opcode-help                             Show Opcode help
  -?|-h|--help                                  Show help information
```
## Example
### Script

Xuất một tập lệnh của Summer Pockets ra dưới định dạng txt, lua, json.

`LucaSystemTools -t scr -m export -f .\10_プロローグ0725 -o .\10_725 -opcode SP -old -lua -json`  
file output：10_725.txt  10_725.lua   10_725.json  

import file cho Summer Pockets.

`LucaSystemTools -t scr -m import -f .\10_725.json -o .\10_725.1 -opcode SP`  
`LucaSystemTools -t scr -m import -f .\10_725.json -o .\10_725.2 -opcode SP -json`  
`LucaSystemTools -t scr -m import -f .\10_725.lua -o .\10_725.3 -opcode SP -lua`  
`LucaSystemTools -t scr -m import -f .\10_725.txt -o .\10_725.4 -opcode SP -old`  
Bốn cách khác nhau để import file.

## OpcodeGuide
[查看README](./LucaSystemTools/README.md)
