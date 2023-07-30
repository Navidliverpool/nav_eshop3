# Welcome to 24 Hours
## :sparkles: 24 Hours is an E-Commerce website :sparkles:

░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
░███░█░█░░██░█░███░█░█░████░░███░
░░░█░█░██░█░░█░█░█░█░███░░█░██░█░
░░░█░█░██░█░░███░█░█░██████░█░░░░
░███░████░██████░█░█░███░░░░████░
░█░░░░░█░░█░░█░█░█░█░█░████░░░██░
░█░░░░░█░██░░█░█░█░███░█░░███░█░░
░█░█░░░█░██░░█░█░█░███░█░░███░██░
░███░░██░░█░░█░███████░█░░██████░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░




### Table of Contents

#### Introduction

#### Features

#### Prerequisites

#### Installation

#### Usage

#### Contributing

#### Introduction

24 Hours is a small-scale e-commerce platform built with ASP.NET Core 7.0 using C# and SQL Server as the database. This project utilizes Razor Pages for the frontend views, providing users with an intuitive and seamless shopping experience.

#### Features

Product Search: 

Easily search for products by name, category, or any relevant keywords, allowing you to find your desired items quickly.

User Registration and Login: 

Create a new account or log in to the platform using your credentials, enabling you to track your orders, manage your profile, and enjoy personalized features.

Product Listing and Selling: 

Sellers can add new products, update existing ones, and manage their inventory effectively. Customers can browse through the diverse range of products available for purchase.

Shopping Cart: 

Conveniently add products to your shopping cart, review your items, and proceed to checkout for a seamless buying experience.

Order Management: 

Keep track of your orders and view order history to ensure a smooth transaction process. ### (under development)

Secure Transactions: 

MyECommerce prioritizes the security of your data, employing encryption and best practices to protect sensitive information. ### (planned)

#### Prerequisites

Before setting up MyECommerce, ensure you have the following prerequisites:

.NET Core SDK 7.0 or later

SQL Server (Express or LocalDB)

A modern web browser

Installation

Clone the MyECommerce repository to your local machine:

bash

git clone https://github.com/Navidliverpool/nav_eshop3.git

Navigate to the project directory:

bash

cd nav_eshop3

Update the connection string in the appsettings.json file with your SQL Server database credentials:

json

"ConnectionStrings": {
  "DefaultConnection": "Server=<your_server_name>;Database=MyECommerceDb;User=<your_db_user>;Password=<your_db_password>;"
}

Apply the database migrations:

sql

dotnet ef database update

Usage

Build and run the application:

arduino

dotnet run

Open your web browser and navigate to http://localhost:5000 to access the MyECommerce platform.

Register a new account or log in with your existing credentials.

Browse through the available products, add items to your shopping cart, and proceed to checkout to place an order.

Sellers can log in to manage their products, update inventory, and track sales.

### Contributing

We welcome contributions to enhance the functionality and usability of MyECommerce. If you find any bugs or have suggestions for improvements, feel free to open an issue or submit a pull request. Please follow the guidelines outlined in the CONTRIBUTING.md file.
