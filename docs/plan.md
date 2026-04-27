# BookTracker - Project Plan

## Project Overview
BookTracker is a full-stack web application that allows users to discover books via the Gutenberg API, create personalized reading lists, and track their reading progress with detailed statistics.

## Technology Stack

### Backend
- **Framework**: ASP.NET Core (.NET 9)
- **Database**: SQL Server (based on existing migrations)
- **Authentication**: Identity (configured in ApplicationDbContext)
- **API Type**: RESTful API

### Frontend
- **Framework**: Next.js (React)
- **Language**: TypeScript
- **Styling**: CSS (with PostCSS)
- **Linting**: ESLint

### External APIs
- **Gutenberg Project API**: For book discovery and metadata

---

## Core Features

### 1. Book Discovery & Management
- Search and browse books from Gutenberg Project API
- View book details (title, author, language, format)
- Add books to personal collection
- Categorize books into custom reading lists

### 2. Reading Lists
- Create custom reading lists (e.g., "To Read", "Favorites", "2026 Reading Challenge")
- Add/remove books from lists
- Track list progress
- Share or export lists

### 3. Reading Tracking
- Mark books as: To Read, Reading, Completed, DNF (Did Not Finish)
- Set reading goals (e.g., books per month)
- Track pages read or % completion
- Add reading sessions with dates

### 4. Reading Statistics
- Total books read
- Books by genre/category
- Monthly/yearly reading trends
- Average reading pace
- Challenge progress tracking
- Reading streak counter

### 5. User Management
- User registration and authentication
- User profiles
- Personal reading history

---

## Database Schema

### Core Tables

#### Users (from ApplicationUser)
```
- UserId (PK)
- Username
- Email
- PasswordHash
- CreatedAt
- UpdatedAt
```

#### Books (core entity)
```
- BookId (PK)
- GutenbergId (external reference)
- Title
- Author
- Language
- PublicationYear
- CoverUrl
- Description
- Format
- ExternalUrl
- CreatedAt
```

#### UserBooks (user-book relationship)
```
- UserBookId (PK)
- UserId (FK)
- BookId (FK)
- ReadingStatus (enum: To Read, Reading, Completed, DNF)
- DateAdded
- DateStarted
- DateCompleted
- Rating (1-5)
- Notes
- PagesRead
- UpdatedAt
```

#### ReadingLists
```
- ListId (PK)
- UserId (FK)
- ListName
- Description
- IsPublic
- CreatedAt
- UpdatedAt
```

#### ListBooks (many-to-many: Lists to Books)
```
- ListBookId (PK)
- ListId (FK)
- BookId (FK)
- AddedAt
```

#### ReadingGoals
```
- GoalId (PK)
- UserId (FK)
- TargetBooks
- TargetMonth
- TargetYear
- Completed
- CreatedAt
```

#### ReadingSessions
```
- SessionId (PK)
- UserBookId (FK)
- SessionDate
- PagesRead
- Notes
- Duration (minutes)
```

---

## API Endpoints

### Authentication
- `POST /api/auth/register` - Register new user
- `POST /api/auth/login` - Login user
- `POST /api/auth/logout` - Logout user

### Books
- `GET /api/books/search?query={query}` - Search Gutenberg API
- `GET /api/books/{id}` - Get book details
- `POST /api/books` - Add book to user's collection

### User Books
- `GET /api/userbooks` - Get user's books with filters
- `PUT /api/userbooks/{id}` - Update book status/rating/notes
- `DELETE /api/userbooks/{id}` - Remove book from collection
- `GET /api/userbooks/{id}/stats` - Get stats for a book

### Reading Lists
- `GET /api/lists` - Get all user's lists
- `POST /api/lists` - Create new list
- `PUT /api/lists/{id}` - Update list
- `DELETE /api/lists/{id}` - Delete list
- `GET /api/lists/{id}/books` - Get books in list
- `POST /api/lists/{id}/books/{bookId}` - Add book to list
- `DELETE /api/lists/{id}/books/{bookId}` - Remove book from list

### Statistics
- `GET /api/stats/overview` - Get reading overview
- `GET /api/stats/monthly` - Get monthly reading data
- `GET /api/stats/genres` - Get book count by genre
- `GET /api/stats/goals` - Get reading goal progress

### Reading Sessions
- `POST /api/sessions` - Log reading session
- `GET /api/sessions?bookId={id}` - Get sessions for book

---

## Frontend Pages & Components

### Pages
- `/` - Home/Dashboard
- `/search` - Book search interface
- `/books` - User's book collection
- `/lists` - Reading lists management
- `/stats` - Reading statistics dashboard
- `/profile` - User profile settings
- `/auth/login` - Login page
- `/auth/register` - Registration page

### Components
- **BookCard** - Display book information
- **SearchBar** - Search Gutenberg API
- **BookList** - List of books with filters/sorting
- **ListManager** - Create/edit reading lists
- **StatsDashboard** - Visualize reading statistics
- **ReadingSessionForm** - Log reading progress
- **Navigation** - Header with user menu

---

## Implementation Phases

### Phase 1: MVP (Weeks 1-2)
- [ ] User authentication (login/register)
- [ ] Basic book search from Gutenberg API
- [ ] Add books to collection
- [ ] Mark reading status (To Read, Reading, Completed)
- [ ] Simple user dashboard

### Phase 2: Reading Lists (Weeks 3-4)
- [ ] Create and manage reading lists
- [ ] Add/remove books from lists
- [ ] Basic statistics (total books, by status)

### Phase 3: Advanced Tracking (Weeks 5-6)
- [ ] Reading sessions logging
- [ ] Reading progress tracking (pages/%)
- [ ] Book ratings and notes
- [ ] Reading goals feature

### Phase 4: Statistics & Analytics (Weeks 7-8)
- [ ] Comprehensive statistics dashboard
- [ ] Monthly/yearly trends
- [ ] Reading streaks
- [ ] Genre analysis
- [ ] Data visualizations (charts)

### Phase 5: Polish & Deployment (Week 9+)
- [ ] Performance optimization
- [ ] Testing (unit & integration)
- [ ] UI/UX refinements
- [ ] Deployment preparation
- [ ] Documentation

---

## Development Workflow

### Backend Development
1. Create Entity Framework migrations for new tables
2. Implement repository pattern for data access
3. Build API controllers with proper validation
4. Add service layer for business logic
5. Error handling and logging

### Frontend Development
1. Create reusable components
2. Implement client-side routing
3. API integration with error handling
4. State management (Context API or similar)
5. Responsive design

### Integration
1. API documentation (Swagger/OpenAPI)
2. CORS configuration
3. End-to-end testing
4. Performance profiling

---

## Key Considerations

### API Integration (Gutenberg)
- Rate limiting compliance
- Caching strategy for frequently searched books
- Fallback handling if API is unavailable

### Performance
- Database indexing on frequently queried fields
- Pagination for large datasets
- Client-side caching

### Security
- Password hashing (Identity handles this)
- Authorization checks for user data
- Input validation on all endpoints
- HTTPS enforcement

### User Experience
- Real-time feedback for long operations
- Loading states and error messages
- Offline capability (optional future feature)
- Mobile responsiveness

---

## Success Metrics
- Users can complete reading list creation workflow in <2 minutes
- Search results load in <1 second
- Statistics calculate and display in <2 seconds
- Mobile usability score >90
- User retention (monthly active users)
