/* 1. Thiết lập phông chữ chung và định dạng vùng chứa menu */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
}

#menu {
    height: 40px;
    background-color: #333333;
}

#menu ul {
    list-style: none;
    margin: 0;
    padding: 0;
}

/* 2. Định nghĩa cho các phần tử cấp 1 hiển thị theo chiều ngang */
#menu > ul > li {
    float: left;
    position: relative; /* Làm mốc cho menu con absolute bên dưới */
}

/* 3. Định dạng liên kết (thẻ a) */
#menu ul li a {
    display: block;
    width: 120px;
    height: 40px;
    line-height: 40px;
    text-align: center;
    color: #ffffff;
    text-decoration: none;
    background-color: #333333;
}

/* 4. Hiệu ứng đổi màu nền sang đỏ khi hover */
#menu ul li a:hover {
    background-color: red;
}

/* 5. Vị trí và ẩn menu con (dropdown) */
#menu ul ul {
    position: absolute;
    top: 40px;
    left: 0;
    visibility: hidden; /* Mặc định ẩn menu con */
    z-index: 1000;
}

#menu ul ul li {
    float: none; /* Các mục trong menu con xếp theo chiều dọc */
}

/* 6. Hiển thị menu con khi di chuột vào mục cha */
#menu ul li:hover > ul {
    visibility: visible;
}