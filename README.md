# Welcome to :sparkles: 24 Hours :sparkles:

##  24 Hours is an E-Commerce website 


╭━━━┳╮╱╭╮╱╱╭╮╱╭┳━━━┳╮╱╭┳━━━┳━━━╮
┃╭━╮┃┃╱┃┃╱╱┃┃╱┃┃╭━╮┃┃╱┃┃╭━╮┃╭━╮┃
╰╯╭╯┃╰━╯┃╱╱┃╰━╯┃┃╱┃┃┃╱┃┃╰━╯┃╰━━╮
╭━╯╭┻━━╮┣━━┫╭━╮┃┃╱┃┃┃╱┃┃╭╮╭┻━━╮┃
┃┃╰━╮╱╱┃┣━━┫┃╱┃┃╰━╯┃╰━╯┃┃┃╰┫╰━╯┃
╰━━━╯╱╱╰╯╱╱╰╯╱╰┻━━━┻━━━┻╯╰━┻━━━╯

<br>

### Table of Contents

#### [Introduction](#Introduction) 

#### [Features](#Features)

#### [Prerequisites](#Prerequisites)

#### [Installation](#installation)

#### [Usage](#usage)

#### [Contributing](#contributing)

<br>

### Introduction 

24 Hours is a small-scale e-commerce platform built with ASP.NET Core 7.0 using C# and SQL Server as the database. This project utilizes Razor Pages for the frontend views, providing users with an intuitive and seamless shopping experience.

<br>

#### Features

  - Product Search: 

Easily search for products by name, category, or any relevant keywords, allowing you to find your desired items quickly. `completed`

  - User Registration and Login: 

Create a new account or log in to the platform using your credentials, enabling you to track your orders, manage your profile, and enjoy personalized features. `completed`

  - Product Listing and Selling: 

Sellers can add new products, update existing ones, and manage their inventory effectively. Customers can browse through the diverse range of products available for purchase. `completed`

  - Shopping Cart: 

Conveniently add products to your shopping cart, review your items, and proceed to checkout for a seamless buying experience. `under development`

  - Nivo Slider-Home Page:
  
Showcase your products with the elegant Nivo Slider, providing a visually appealing and interactive product display. `completed`

  - Admin Section:
  - 
A powerful and secure admin section for managing the platform. Administrators can oversee users, products, orders, and other crucial aspects of the system to ensure efficient and effective operation. `planned`

  - Order Management: 

Keep track of your orders and view order history to ensure a smooth transaction process. `under development`

  - Secure Transactions: 

MyECommerce prioritizes the security of your data, employing encryption and best practices to protect sensitive information. `planned`

<br>

#### Home Page
![screencapture-localhost-7188-2023-07-30-21_39_50](https://github.com/Navidliverpool/nav_eshop3/assets/71192720/90709f38-92f5-41ba-bac6-21a5ad0a3a01)

<br>

#### Prerequisites 

  - Before setting up MyECommerce, ensure you have the following prerequisites:

     - .NET Core SDK 7.0

     - SQL Server (Express or LocalDB)

     - A modern web browser

<br>

#### Create Product Page

![screencapture-localhost-7188-Products-Create-2023-07-30-21_41_18](https://github.com/Navidliverpool/nav_eshop3/assets/71192720/99d0f87b-f681-44ca-9c3b-07446f43d3e9)

<br>

<br>

Please visit the website to explore More about it.

<br>

### Installation 

  - Clone the 24 Hours repository to your local machine:

bash
```
git clone https://github.com/Navidliverpool/nav_eshop3.git
```

  - Navigate to the project directory:

bash
```
cd nav_eshop3
```

  - Update the connection string in the appsettings.json file with your SQL Server database credentials:

json
```
"ConnectionStrings": {
  "DefaultConnection": "Server=<your_server_name>;Database=MyECommerceDb;User=<your_db_user>;Password=<your_db_password>;"
}
```

  - Apply the database migrations:

sql
```
dotnet ef database update
```

<br>

### Usage

  - Build and run the application:

arduino
```
dotnet run
```

<br>

Open your web browser and navigate to http://localhost:5000 to access the MyECommerce platform.

Register a new account or log in with your existing credentials.

Browse through the available products, add items to your shopping cart, and proceed to checkout to place an order.

Sellers can log in to manage their products, update inventory, and track sales.

### Contributing

I welcome contributions to enhance the functionality and usability of 24 Hours. If you find any bugs or have suggestions for improvements, opening an issue or submitting a pull request would be appreciated. 

## LETS CODE TOGATHER 💻
