# 🍔 FoodCourt Management System

[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-green.svg)](https://learn.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-netcore)
[![Database](https://img.shields.io/badge/Database-SQL%20Server%20LocalDB-orange.svg)](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A comprehensive Windows Forms-based management system designed for food courts to handle user authentication, menu inventory, order processing, and sales tracking.

---

## 📋 Overview

The **FoodCourt Management System** is a desktop application built with **C#** and **.NET 8.0** that streamlines daily food court operations. It provides distinct interfaces for administrators, registered users, and guests, enabling efficient management of users, food items, and orders, all backed by a robust SQL Server LocalDB database.

---

## ✨ Features

### 🔐 Authentication & Authorization
* **User Registration:** Secure sign-up with SHA256 password hashing.
* **Role-Based Access:** Separate workflows and dashboards for Admins, Users, and Guests.
* **Session Management:** Persistent user sessions across different forms.
* **Security:** Industry-standard SHA256 hashing for safe password storage.

### 👥 User Management
* **CRUD Operations:** Create, edit, and delete customer accounts easily.
* **Profile Management:** Store details such as Name, Phone, and Password.
* **Admin Dashboard:** `DataGridView` interface for quick user administration.

### 🍽️ Item Management
* **Inventory Control:** Manage food items across categories:
    * 🍚 Rice Box
    * 🍔 Burger
    * 🌯 Wrap
    * 🥤 Cold Drink
    * 🍰 Desserts
* **Edit Capability:** Add, edit, and delete menu items dynamically.
* **Tracking:** Monitor item numbers, names, categories, and prices.

### 🛒 Order Processing
* **Registered User Orders:** Place orders with automatic seller/user tracking.
* **Guest Ordering:** hassle-free anonymous ordering capability.
* **Smart Filtering:** Filter menu items by food category.
* **Shopping Cart:** Add multiple items with quantity adjustments.
* **Auto-Calculation:** Real-time total amount calculation.
* **Order History:** View past orders and transaction details.

### 📊 Reporting & Views
* **Order Logs:** View complete order lists with timestamp details.
* **Summaries:** Print or view order summaries.
* **Revenue Tracking:** Monitor order amounts and sales volume.

---

## 🛠️ Tech Stack

| Technology | Version | Purpose |
| :--- | :--- | :--- |
| **C#** | 12.0 | Primary programming language |
| **.NET** | 8.0 | Application framework |
| **Windows Forms** | .NET 8.0 | UI framework |
| **SQL Server LocalDB** | 2019+ | Database engine |
| **Microsoft.Data.SqlClient** | 5.2.2 | Data access provider |
| **SHA256** | System.Security | Password hashing |

---

## 📦 Prerequisites

Before running the application, ensure you have the following installed:
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (with .NET desktop development workload)
* [SQL Server 2019 Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb)
* Windows 10/11 operating system

---

## 🚀 Installation & Setup

### 1. Clone the Repository
Open your terminal or command prompt and run:

```bash
git clone [https://github.com/Tayeebi/FoodCourt_Management_System.git](https://github.com/Tayeebi/FoodCourt_Management_System.git)
cd FoodCourt_Management_System
