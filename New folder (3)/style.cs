body {
    margin: 0;
    font-family: Arial, sans-serif;
}

/* Định dạng thanh menu cố định phía trên */
.navbar {
    overflow: hidden;
    background-color: #333;
    position: fixed;
    top: 0;
    width: 100%;
    z-index: 1000; /* Đảm bảo menu luôn nằm trên cùng */
}

/* Định dạng các liên kết trong menu */
.navbar a {
    float: left;
    display: block;
    color: #f2f2f2;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    font-size: 17px;
}

.navbar a:hover {
    background-color: #ddd;
    color: black;
}

/* Định dạng khối nội dung chính */
.main {
    padding: 16px;
    margin-top: 50px; /* Tránh cho nội dung bị che lấp bởi fixed menu */
    height: 1500px;  /* Tạo chiều cao lớn để hiển thị thanh cuộn */
}