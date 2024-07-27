# Sports Shopping Cart Application

This is a Sports Shopping Cart web application built with ASP.NET Core using MVC, Razor Pages, and Blazor Server for a versatile and robust user experience. The project follows the structure and examples provided in "Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages, Ninth Edition" by Adam Freeman.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies](#technologies)
- [Setup](#setup)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Overview

The Sports Shopping Cart application is designed to provide a seamless shopping experience for users looking to purchase sports equipment and apparel. This project showcases the use of different ASP.NET Core components, demonstrating how they can be integrated to build a comprehensive web application.

## Features

- **MVC**: Utilized for the main shopping cart functionalities.
- **Razor Pages**: Employed for simple page-based interactions.
- **Blazor Server**: Integrated for real-time, interactive user experiences.

## Technologies

- **ASP.NET Core 6**
- **MVC**
- **Razor Pages**
- **Blazor Server**
- **Entity Framework Core** (for database interactions)
- **Bootstrap** (for styling)

## Setup

### Prerequisites

- .NET 6 SDK or later
- Visual Studio 2022
- SQL Server

### Installation

1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/sports-shopping-cart.git
   cd sports-shopping-cart

2. Configure the database:
- Update the appsettings.json file with your database connection string

3. Apply Migrations:
    ```sh
    dotnet ef database update

4. Run the application:
    ```sh
    dotnet run

## Usage
- Home Page: Browse the available sports products.
- Add to Cart: Add desired products to the shopping cart.
- Checkout: Proceed to purchase the selected products.
- /admin: Admin page with login.
- Test account: username: admin, password: password111@

## Project Structure
- Controllers: Handles user input and interactions.
- Models: Represents the data structure.
- Views: Contains the Views for rendering the UI.
- Pages: Contains the Razor Pages for rendering the UI.
- Components: Contains ViewComponent files.
- Infrastructure: Contains helper files for the project.

## Contributing
Contributions are welcome! Please fork this repository and submit a pull request with your changes. Ensure that your code adheres to the project's coding standards and is well-documented.

## License
This project is licensed under the MIT License. See the LICENSE file for more information.

This application is based on the principles and examples provided in "Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages, Ninth Edition" by Adam Freeman.
Special thanks to the author for the comprehensive guide and invaluable insights into ASP.NET Core development.
  
