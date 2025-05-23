# TodoApi

A simple Todo List API built with .NET 9 that supports CRUD operations using an in-memory database.


![Live Deployment](https://img.shields.io/badge/Live-Deployed-success)

## 🌐 Live Deployment

**Production API URL:**  
[https://todoapi-ul16.onrender.com](https://todoapi-ul16.onrender.com)

**Live Testing link:**  
[https://todoapi-ul16.onrender.com/swagger/index.html](https://todoapi-ul16.onrender.com/swagger/index.html)

## Features

[Previous features list remains same...]

## Getting Started

### Installation

[Previous installation steps remain same...]

## API Endpoints

**Base URL:** `https://todoapi-ul16.onrender.com/api/todos`

| Method | Endpoint          | Description                  |
|--------|-------------------|------------------------------|
| GET    | /                 | Get all todo items           |
| GET    | /{id}             | Get a specific todo item     |
| POST   | /                 | Create a new todo item       |
| PUT    | /{id}             | Update an existing todo item |
| DELETE | /{id}             | Delete a todo item           |

## Testing the API

### 1. Using Live Swagger UI
Visit the deployed Swagger documentation to test endpoints directly in your browser:  
[https://todoapi-ul16.onrender.com/swagger/index.html](https://todoapi-ul16.onrender.com/swagger/index.html)

### 2. Using Curl Examples

**Create Todo:**
```bash
curl -X POST "https://todoapi-ul16.onrender.com/api/todos" \
-H "Content-Type: application/json" \
-d '{"title":"Live Test Todo","isCompleted":false}'
