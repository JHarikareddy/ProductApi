# Product Inventory Management API

## Project Description

This project is a RESTful Web API developed using ASP.NET Core for managing product inventory. It allows users to perform CRUD (Create, Read, Update, Delete) operations and includes additional features like filtering, sorting, and stock management.

---

## Objective

To build a real-world Product Inventory Management API using:

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server

---

## Product Model

The Product entity contains the following fields:

* **Id** – Unique identifier
* **Name** – Product name
* **Category** – Product category
* **Price** – Product price
* **StockQuantity** – Available stock

---

## Features

### Core Features

* Add a new product
* View all products
* View product by ID
* Update product details
* Delete a product

### Bonus Features

* Filter products by category
* Sort products by price (ascending/descending)
* View out-of-stock products

---

## Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* Swagger (API testing)

---

##  Setup Instructions

### 1. Install Required Software

* .NET SDK
* SQL Server
* SQL Server Management Studio (SSMS)

### 2. Clone or Download the Repository

Download ZIP or clone using Git.

### 3. Open Project

Open the project folder in **Visual Studio Code**.

### 4. Configure Database

Update the connection string in `appsettings.json` with your SQL Server details.

### 5. Apply Migrations

Run the following command:
dotnet ef database update

### 6. Run the Application

dotnet run

### 7. Access Swagger UI

Open in browser:

http://localhost:5000/swagger

---

##  API Endpoints

###  Basic CRUD

| Method | Endpoint           | Description       |
| ------ | ------------------ | ----------------- |
| GET    | /api/products      | Get all products  |
| GET    | /api/products/{id} | Get product by ID |
| POST   | /api/products      | Add new product   |
| PUT    | /api/products/{id} | Update product    |
| DELETE | /api/products/{id} | Delete product    |

---

###  Bonus Feature Endpoints

| Method | Endpoint                          | Description                |
| ------ | --------------------------------- | -------------------------- |
| GET    | /api/products/category/{category} | Filter by category         |
| GET    | /api/products/sort/asc            | Sort by price (ascending)  |
| GET    | /api/products/sort/desc           | Sort by price (descending) |
| GET    | /api/products/outofstock          | Get out-of-stock products  |

---

##  Validation & Error Handling

* Returns **400 BadRequest** for invalid input
* Returns **404 NotFound** when product is not found
* Proper exception handling implemented

---

##  Expected Outcome

A fully functional Web API connected to SQL Server that performs CRUD operations along with advanced filtering and sorting features.

---

