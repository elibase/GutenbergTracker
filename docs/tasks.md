# BookTracker - Tasks & Checklist

## Phase 1: MVP (Weeks 1-2)

### Backend Setup & Authentication
- [ ] Create ApplicationUser model extensions if needed
- [ ] Configure Identity authentication in Program.cs
- [ ] Create AuthController with Register endpoint
- [ ] Create AuthController with Login endpoint
- [ ] Create AuthController with Logout endpoint
- [ ] Add JWT token generation (or session-based auth)
- [ ] Add password validation and hashing
- [ ] Create authentication middleware
- [ ] Add CORS configuration for frontend

### Database & Models
- [ ] Update Book model with GutenbergId, CoverUrl, ExternalUrl fields
- [ ] Create/update UserBook model with ReadingStatus enum
- [ ] Create ReadingStatus enum (To Read, Reading, Completed, DNF)
- [ ] Create database migration for Book table
- [ ] Create database migration for UserBook table
- [ ] Apply migrations to database
- [ ] Add database seeding (optional test data)

### Backend Repositories & Services
- [ ] Implement BookRepository with basic CRUD
- [ ] Implement UserBooksRepository with status filtering
- [ ] Create IBookService interface
- [ ] Create BookService with business logic
- [ ] Create IUserBooksService interface
- [ ] Create UserBooksService with business logic

### Gutenberg API Integration
- [ ] Research Gutenberg Project API endpoints and structure
- [ ] Create GutenbergClient service for API calls
- [ ] Implement book search functionality
- [ ] Implement book detail retrieval
- [ ] Add error handling and retry logic
- [ ] Add caching mechanism for searches
- [ ] Create unit tests for GutenbergClient

### Backend API Endpoints (Phase 1)
- [ ] POST /api/auth/register
- [ ] POST /api/auth/login
- [ ] POST /api/auth/logout
- [ ] GET /api/books/search?query={query}
- [ ] GET /api/books/{id}
- [ ] POST /api/books (add to collection)
- [ ] GET /api/userbooks (get user's books with filters)
- [ ] PUT /api/userbooks/{id} (update status)
- [ ] DELETE /api/userbooks/{id}
- [ ] Add input validation to all endpoints
- [ ] Add error handling to all endpoints
- [ ] Create API.http file with test requests

### Frontend Setup
- [ ] Verify Next.js project structure
- [ ] Configure TypeScript settings
- [ ] Setup ESLint and code formatting
- [ ] Create API client service (axios/fetch wrapper)
- [ ] Setup environment variables for backend URL
- [ ] Create authentication context/state management
- [ ] Create basic app layout (header, sidebar, main content)

### Frontend Pages (Phase 1)
- [ ] Create /auth/login page
- [ ] Create /auth/register page
- [ ] Create / (home/dashboard) page - basic layout
- [ ] Create /search page for book search
- [ ] Create /books page to display user's books
- [ ] Add navigation between pages

### Frontend Components (Phase 1)
- [ ] Create BookCard component
- [ ] Create SearchBar component
- [ ] Create BookList component with filtering
- [ ] Create Navigation component
- [ ] Create UserMenu component
- [ ] Create LoginForm component
- [ ] Create RegisterForm component
- [ ] Create LoadingSpinner component
- [ ] Create ErrorAlert component

### Frontend Features (Phase 1)
- [ ] Implement user login functionality
- [ ] Implement user registration
- [ ] Implement book search from Gutenberg API
- [ ] Implement add book to collection
- [ ] Implement change reading status
- [ ] Implement view user's book collection
- [ ] Add loading states
- [ ] Add error handling and user feedback
- [ ] Add responsive design for mobile

### Testing (Phase 1)
- [ ] Setup testing framework (xUnit for backend)
- [ ] Setup testing framework (Jest for frontend)
- [ ] Create unit tests for authentication
- [ ] Create integration tests for book search
- [ ] Create component tests for key UI components

---

## Phase 2: Reading Lists (Weeks 3-4)

### Database & Models
- [ ] Create ReadingList model
- [ ] Create ListBook join table model
- [ ] Update User model for reading lists relationship
- [ ] Create database migrations
- [ ] Apply migrations to database

### Backend Repositories & Services
- [ ] Implement ReadingListRepository
- [ ] Create IReadingListService interface
- [ ] Create ReadingListService
- [ ] Add methods for list CRUD operations
- [ ] Add methods for adding/removing books from lists
- [ ] Add methods for filtering lists

### Backend API Endpoints (Phase 2)
- [ ] GET /api/lists (get all user's lists)
- [ ] POST /api/lists (create new list)
- [ ] PUT /api/lists/{id} (update list)
- [ ] DELETE /api/lists/{id} (delete list)
- [ ] GET /api/lists/{id}/books (get books in list)
- [ ] POST /api/lists/{id}/books/{bookId} (add book to list)
- [ ] DELETE /api/lists/{id}/books/{bookId} (remove book from list)
- [ ] Add validation and error handling

### Basic Statistics
- [ ] GET /api/stats/overview (total books, by status)
- [ ] Create StatsService for calculations
- [ ] Add books read count
- [ ] Add books currently reading count
- [ ] Add to-read count

### Frontend Pages (Phase 2)
- [ ] Create /lists page for reading lists management
- [ ] Create list detail page
- [ ] Create list creation modal/form
- [ ] Implement create list functionality
- [ ] Implement update list functionality
- [ ] Implement delete list functionality

### Frontend Components (Phase 2)
- [ ] Create ListCard component
- [ ] Create ListForm component
- [ ] Create ListManager component
- [ ] Create BookListView component (for list detail)
- [ ] Create StatsSummary component (basic)

### Frontend Features (Phase 2)
- [ ] Implement view all reading lists
- [ ] Implement create reading list
- [ ] Implement edit reading list
- [ ] Implement delete reading list
- [ ] Implement add book to list
- [ ] Implement remove book from list
- [ ] Display basic stats on dashboard

### Testing (Phase 2)
- [ ] Unit tests for ReadingListService
- [ ] Integration tests for list endpoints
- [ ] Component tests for list-related UI

---

## Phase 3: Advanced Tracking (Weeks 5-6)

### Database & Models
- [ ] Create ReadingGoal model
- [ ] Create ReadingSession model
- [ ] Create database migrations
- [ ] Apply migrations to database

### Backend Repositories & Services
- [ ] Implement ReadingGoalRepository
- [ ] Implement ReadingSessionRepository
- [ ] Create IReadingGoalService interface
- [ ] Create ReadingGoalService
- [ ] Create IReadingSessionService interface
- [ ] Create ReadingSessionService

### Backend API Endpoints (Phase 3)
- [ ] POST /api/sessions (log reading session)
- [ ] GET /api/sessions?bookId={id} (get sessions for book)
- [ ] PUT /api/sessions/{id} (update session)
- [ ] DELETE /api/sessions/{id} (delete session)
- [ ] GET /api/stats/goals (get reading goal progress)
- [ ] POST /api/goals (create reading goal)
- [ ] PUT /api/goals/{id} (update goal)
- [ ] GET /api/goals (list user's goals)
- [ ] Add validation and error handling

### Backend Features (Phase 3)
- [ ] Add rating field to UserBook
- [ ] Add notes field to UserBook
- [ ] Add pages read field to UserBook
- [ ] Update UserBooksRepository for new fields
- [ ] Create tracking service for reading progress

### Frontend Pages (Phase 3)
- [ ] Create reading session logging page
- [ ] Create goals management page
- [ ] Update book detail view with session history

### Frontend Components (Phase 3)
- [ ] Create ReadingSessionForm component
- [ ] Create SessionList component
- [ ] Create GoalCard component
- [ ] Create GoalForm component
- [ ] Create ProgressBar component
- [ ] Create RatingInput component

### Frontend Features (Phase 3)
- [ ] Implement log reading session
- [ ] Implement view session history
- [ ] Implement edit session
- [ ] Implement delete session
- [ ] Implement book rating
- [ ] Implement book notes/review
- [ ] Implement reading goals creation
- [ ] Implement goal progress tracking
- [ ] Display pages read percentage

### Testing (Phase 3)
- [ ] Unit tests for session/goal services
- [ ] Integration tests for tracking endpoints
- [ ] Component tests for tracking UI

---

## Phase 4: Statistics & Analytics (Weeks 7-8)

### Backend Statistics Service
- [ ] Create comprehensive StatsService
- [ ] Implement monthly reading statistics calculation
- [ ] Implement yearly reading statistics calculation
- [ ] Implement genre analysis
- [ ] Implement reading streak calculation
- [ ] Implement reading pace calculation
- [ ] Add caching for stat calculations

### Backend API Endpoints (Phase 4)
- [ ] GET /api/stats/monthly (monthly reading data)
- [ ] GET /api/stats/yearly (yearly reading data)
- [ ] GET /api/stats/genres (books by genre)
- [ ] GET /api/stats/streak (current reading streak)
- [ ] GET /api/stats/pace (reading pace)
- [ ] GET /api/stats/goals-progress (goal progress details)

### Frontend Pages (Phase 4)
- [ ] Create comprehensive /stats dashboard page
- [ ] Create statistics detail pages

### Frontend Components (Phase 4)
- [ ] Create StatsDashboard component
- [ ] Create BarChart component (monthly/yearly)
- [ ] Create PieChart component (genres)
- [ ] Create LineChart component (reading trends)
- [ ] Create StatsCard component
- [ ] Create StreakBadge component
- [ ] Create GoalProgressWidget component

### Frontend Features (Phase 4)
- [ ] Display reading overview
- [ ] Display monthly reading statistics
- [ ] Display yearly reading statistics
- [ ] Display books by genre
- [ ] Display reading streaks
- [ ] Display average reading pace
- [ ] Display goal progress
- [ ] Add date range filtering
- [ ] Add export statistics functionality

### Data Visualization
- [ ] Install charting library (recharts/chart.js)
- [ ] Create custom chart components
- [ ] Add trend visualizations
- [ ] Add interactive filters

### Testing (Phase 4)
- [ ] Unit tests for StatsService calculations
- [ ] Integration tests for stats endpoints
- [ ] Component tests for charts
- [ ] Performance tests for stat queries

---

## Phase 5: Polish & Deployment (Week 9+)

### Backend Refinements
- [ ] Add comprehensive logging
- [ ] Setup error tracking (Sentry or similar)
- [ ] Create Swagger/OpenAPI documentation
- [ ] Add rate limiting to API endpoints
- [ ] Setup request validation middleware
- [ ] Add database query optimization
- [ ] Create health check endpoint
- [ ] Add version versioning to API

### Frontend Refinements
- [ ] Audit and optimize bundle size
- [ ] Implement image lazy loading
- [ ] Optimize API calls (batching where applicable)
- [ ] Add PWA capabilities (optional)
- [ ] Implement client-side caching
- [ ] Add offline functionality (optional)
- [ ] Improve accessibility (WCAG compliance)
- [ ] Add analytics tracking

### Testing & Quality Assurance
- [ ] Run full test suite
- [ ] Perform code review
- [ ] Setup CI/CD pipeline
- [ ] Create end-to-end tests
- [ ] Performance testing (load testing)
- [ ] Security testing (OWASP)
- [ ] Cross-browser testing
- [ ] Mobile device testing

### Deployment Preparation
- [ ] Setup production database
- [ ] Configure production environment variables
- [ ] Setup SSL/HTTPS
- [ ] Configure backup strategy
- [ ] Setup monitoring and alerting
- [ ] Create deployment documentation
- [ ] Create user documentation
- [ ] Create API documentation
- [ ] Setup user feedback mechanism

### DevOps & Infrastructure
- [ ] Choose hosting provider (Azure, AWS, etc.)
- [ ] Setup Docker containers (optional)
- [ ] Setup automated deployments
- [ ] Configure CDN for static assets
- [ ] Setup database backups
- [ ] Setup log aggregation
- [ ] Create disaster recovery plan

### Documentation
- [ ] Write API documentation (Swagger)
- [ ] Write user guide
- [ ] Write developer guide
- [ ] Create architecture documentation
- [ ] Create deployment guide
- [ ] Add code comments where needed
- [ ] Create troubleshooting guide

### Final Testing & Launch
- [ ] User acceptance testing (UAT)
- [ ] Fix critical bugs from UAT
- [ ] Performance optimization
- [ ] Security audit
- [ ] Backup verification
- [ ] Deploy to production
- [ ] Monitor application post-launch
- [ ] Support for initial users

---

## Ongoing & Cross-Phase

### Code Quality & Maintenance
- [ ] Setup code formatting standards (Prettier, ReSharper)
- [ ] Setup pre-commit hooks
- [ ] Regular code reviews
- [ ] Refactoring of technical debt
- [ ] Update dependencies regularly
- [ ] Monitor security vulnerabilities

### Documentation Updates
- [ ] Keep README up to date
- [ ] Update plan.md as scope changes
- [ ] Update API documentation
- [ ] Add architecture diagrams
- [ ] Document deployment process

### Performance Monitoring
- [ ] Setup application performance monitoring (APM)
- [ ] Monitor API response times
- [ ] Monitor database query performance
- [ ] Track frontend performance metrics
- [ ] Monitor user experience metrics

### User Support & Feedback
- [ ] Collect user feedback
- [ ] Track bugs reported
- [ ] Prioritize feature requests
- [ ] Respond to support inquiries
- [ ] Update FAQ/help documentation

---

## Legend
- [ ] Task not started
- [x] Task completed
