-- SQL structure for library

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'db_library')
    BEGIN
        CREATE DATABASE [db_library]
    END
GO

USE db_library;

DROP TABLE IF EXISTS write;
DROP TABLE IF EXISTS authors;
DROP TABLE IF EXISTS copies_books;
DROP TABLE IF EXISTS books;
DROP TABLE IF EXISTS book_publishers;
DROP TABLE IF EXISTS lending_points;
DROP TABLE IF EXISTS books_conditions;
DROP TABLE IF EXISTS customers;
DROP TABLE IF EXISTS addresses;



CREATE TABLE book_publishers(
    book_publisher_name VARCHAR(64) UNIQUE NOT NULL,
    CONSTRAINT PK_book_publishers_name PRIMARY KEY (book_publisher_name)
);

CREATE TABLE books(
    book_isbn CHAR(13) UNIQUE NOT NULL,
    book_title VARCHAR(64) NOT NULL,
    book_book_publisher_name VARCHAR(64) NULL,
    CONSTRAINT PK_books_isbn PRIMARY KEY (book_isbn),
    CONSTRAINT FK_books_book_publisher_name FOREIGN KEY (book_book_publisher_name) REFERENCES book_publishers(book_publisher_name)
);

CREATE TABLE authors(
    author_id INT UNIQUE NOT NULL,
    author_firstname VARCHAR(32) NOT NULL,
    author_lastname VARCHAR(32) NOT NULL,
    CONSTRAINT PK_authors_id PRIMARY KEY (author_id)
);

CREATE TABLE write(
    write_book_isbn CHAR(13) NOT NULL,
    write_author_id INT NOT NULL,
    CONSTRAINT PK_write_id PRIMARY KEY (write_author_id, write_book_isbn),
    CONSTRAINT FK_write_book_isbn FOREIGN KEY (write_book_isbn) REFERENCES books(book_isbn),
    CONSTRAINT FK_write_author_id FOREIGN KEY (write_author_id) REFERENCES authors(author_id)
);

CREATE TABLE books_conditions(
    book_condition_status VARCHAR(64) NOT NULL UNIQUE,
    CONSTRAINT PK_books_conditions_id PRIMARY KEY (book_condition_status)
);

CREATE TABLE addresses(
    address_street VARCHAR(128) NOT NULL,
    address_city VARCHAR(32) NOT NULL,
    address_zipcode CHAR(5) NOT NULL,
    CONSTRAINT PK_addresses_id PRIMARY KEY (address_street, address_city, address_zipcode)
)

CREATE TABLE lending_points(
    lending_point_name VARCHAR(64) NOT NULL UNIQUE,
    lending_point_street VARCHAR(128) NOT NULL,
    lending_point_city VARCHAR(32) NOT NULL,
    lending_point_zipcode CHAR(5) NOT NULL,
    CONSTRAINT PK_lending_points_id PRIMARY KEY (lending_point_name),
    CONSTRAINT FK_lending_addresses
        FOREIGN KEY (lending_point_street, lending_point_city, lending_point_zipcode)
        REFERENCES addresses(address_street, address_city, address_zipcode)
);

CREATE TABLE customers(
    customer_id INT NOT NULL UNIQUE,
    customer_firstname VARCHAR(32) NOT NULL,
    customer_lastname VARCHAR(32) NOT NULL,
    customer_deposit_paid SMALLINT NOT NULL DEFAULT 0,
    customer_street VARCHAR(128) NOT NULL,
    customer_city VARCHAR(32) NOT NULL,
    customer_zipcode CHAR(5) NOT NULL,
    CONSTRAINT PK_customers_id PRIMARY KEY (customer_id),
    CONSTRAINT FK_customers_street
        FOREIGN KEY (customer_street, customer_city, customer_zipcode)
        REFERENCES addresses(address_street, address_city, address_zipcode)
);

CREATE TABLE copies_books(
    copy_book_id INT NOT NULL UNIQUE,
    copy_book_date_purchase DATETIME NOT NULL,
    copy_book_lending_point_name VARCHAR(64) NOT NULL,
    copy_book_condition_status VARCHAR(64) NOT NULL,
    copy_book_isbn CHAR(13) NOT NULL,
    CONSTRAINT PK_copies_books_id PRIMARY KEY (copy_book_id),
    CONSTRAINT FK_copies_books_lending_point
        FOREIGN KEY (copy_book_lending_point_name)
        REFERENCES lending_points(lending_point_name),
    CONSTRAINT FK_copies_books_condition
        FOREIGN KEY (copy_book_condition_status)
        REFERENCES books_conditions(book_condition_status),
    CONSTRAINT FK_copies_books_isbn
        FOREIGN KEY (copy_book_isbn)
        REFERENCES books(book_isbn)
);

CREATE TABLE borrow(
    borrow_copy_book_id INT NOT NULL,
    borrow_customer_id INT NOT NULL,
    borrow_date_start DATE NOT NULL,
    borrow_date_end DATE NULL,
    CONSTRAINT PK_borrow_id PRIMARY KEY (borrow_copy_book_id, borrow_customer_id),
    CONSTRAINT FK_borrow_copy_book FOREIGN KEY (borrow_copy_book_id) REFERENCES copies_books(copy_book_id),
    CONSTRAINT FK_borrow_customer_id FOREIGN KEY (borrow_customer_id) REFERENCES customers(customer_id),
);
