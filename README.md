# Asp.Net-MVC-CRUD-Without-Entity-Framework

## Overview

This project is an ASP.NET MVC 6 application that demonstrates basic CRUD (Create, Read, Update, Delete) operations on a `Product` entity using Razor Pages. The project does not use Entity Framework; instead, it employs a custom data access layer to interact with the database.

## Features

- **Create**: Add new products to the database.
- **Read**: Retrieve and display product information.
- **Update**: Edit and update existing product details.
- **Delete**: Remove products from the database.
- **Custom Data Access Layer**: Manages database operations without Entity Framework.

## Product Entity

The `Product` entity includes the following properties:

- **Product ID**: A unique identifier for each product.
- **Name**: The name of the product.
- **Price**: The price of the product.
- **Count**: The quantity of the product in stock.

## Technologies Used

- **ASP.NET MVC 6**: Framework for building the web application.
- **Razor Pages**: Used for building the UI.
- **SQL Server**: Database management system for storing product data.
- **HTML/CSS/JavaScript**: Front-end technologies.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- Visual Studio 2022 or later
- .NET 6 SDK installed
- SQL Server instance (local or remote)

## Getting Started

Follow these steps to get a copy of the project up and running on your local machine.

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/Asp.Net-MVC-CRUD-Without-Entity-Framework.git
```

### 2. Open the Solution
- Open the `Asp.Net-MVC-CRUD-Without-Entity-Framework.`sln file in Visual Studio.

### 3. Configure the Database
- Update the connection string in the `Productcontroller ` file to point to your SQL Server database.

### 4. Run the Application
- Build and run the application using Visual Studio.
- Navigate to `http://localhost:your_port` in your browser to see the CRUD operations in action.

## Project Structure
- **Controllers**: Handles the incoming HTTP requests and processes them.
- **Views**: Razor Pages that present data to the user.
- **Models**: Contains the `Product` class representing the data structure.

## CRUD Operations Overview
- **Create**: Use the "Add Product" page to add a new product by providing the product name, price, and count.
- **Read**: The "Home" page displays all products currently in the database.
- **Update** : Click on a product in the list to edit its details
- **Delete**: Remove a product from the list by clicking the delete button next to it.

## Contributing
If you'd like to contribute to this project, please fork the repository and create a pull request. We welcome all contributions that can improve the project.


## License

- This project is licensed under the MIT License - see the LICENSE file for details.

## Contact
- If you have any questions or suggestions, feel free to reach out.
- **Author**: Tushar Mankar
- **Email**: tusharmankar02@gmail.com
