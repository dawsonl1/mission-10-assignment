# Bowling League App

A React + .NET app for displaying bowling league data.

## Tech Stack

- **Frontend**: React, TypeScript, Vite
- **Backend**: .NET Web API, Entity Framework Core, PostgreSQL

## Setup

### Backend

```bash
cd backend
dotnet run
```

### Frontend

```bash
cd frontend
npm install
npm run dev
```

## Features

- Displays bowlers from Marlins and Sharks teams
- Shows bowler name, address, and team info
- RESTful API at `/api/Bowlers`

## Project Structure

```text
backend/          # .NET API with SQLite database
frontend/         # React app with TypeScript
```

## API

- `GET /api/Bowlers` - Returns bowlers from Marlins and Sharks teams

## Author

Created by Dawson Pitcher
