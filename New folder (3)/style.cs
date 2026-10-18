/* Thiết lập quy tắc chung cho font chữ và margin/padding */
body, ul, li {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
}

/* Định dạng cho các phần tử danh sách (li) */
#menu ul li {
    list-style: none;            /* Bỏ dấu chấm bullet */
    position: relative;          /* Làm mốc vị trí cho menu con absolute */
    width: 120px;
    height: 30px;
    padding: 0 20px;
    background-color: black;
    line-height: 30px;
    cursor: pointer;
}

/* Định dạng thẻ liên kết a trong menu */
#menu ul li a {
    text-decoration: none;       /* Bỏ gạch chân */
    color: white;               /* Màu chữ trắng */
    display: block;
}

/* Hiệu ứng đổi màu nền khi di chuột qua mục menu */
#menu ul li:hover {
    background-color: #333333;
}

/* Định dạng danh sách menu con (Dropdown) */
#menu ul li ul {
    position: absolute;
    top: 0;
    left: 160px;                /* Đặt menu con nằm sang bên phải (width 120px + padding 40px) */
    visibility: hidden;         /* Ẩn menu con mặc định */
}

/* Hiển thị menu con khi di chuột vào phần tử cha */
#menu ul li:hover > ul {
    visibility: visible;
}