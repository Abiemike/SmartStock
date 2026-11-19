SmartStock
  SmartStock is an Inventory and Warehouse Management System built with ASP.NET Core Web API and Entity Framework Core. The system helps organizations manage products,   warehouses, inventory balances, and stock transactions with real-time inventory visibility.
  Overview
SmartStock is designed to streamline inventory operations and warehouse management processes. It provides RESTful APIs for managing products, warehouses, stock movements, inventory balances, and transaction history.

Features
Product Management
Warehouse Management
Inventory Balance Tracking
Inventory Transaction History
Stock Receiving
SQL Server Integration
RESTful API Architecture
Entity Framework Core Migrations
OpenAPI Documentation

Architecture
ASP.NET Core Web API
Entity Framework Core
SQL Server Database
RESTful Services
Layered Project Structure
Technology Stack
ASP.NET Core Web API
C#
Entity Framework Core
SQL Server
Swagger / OpenAPI
Visual Studio 2022
Postman
Installation
Clone Repository
git clone https://github.com/Abiemike/SmartStock.git
Navigate to Project
cd SmartStock
Update Database
Update-Database
Run Application
dotnet run
API Endpoints
Products
Method	Endpoint
GET	/api/products
POST	/api/products
Warehouses
Method	Endpoint
GET	/api/warehouses
POST	/api/warehouses
Inventory
Method	Endpoint
POST	/api/inventory/receive
GET	/api/inventory/balances
GET	/api/inventory/transactions

Future Enhancements
Inventory Issue Management
Stock Transfers
Supplier Management
Purchase Orders
Sales Orders
JWT Authentication
Role-Based Access Control (RBAC)
Inventory Reports
Analytics Dashboard
