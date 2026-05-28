import "../app/globals.css";

export default function HomePage({
  
}) {
  return (
    <main className="min-h-screen bg-[var(--background)] text-[var(--foreground)]">
      {/* NAVBAR */}
      <header className="border-b border-[var(--border)]">
        <div className="container-page flex items-center justify-between py-6">
          <div className="flex items-center gap-4">
            <h2 className="serif text-3xl font-semibold">
              GutenTracker
            </h2>

            <span className="editorial-label hidden md:block">
              Public Domain Reading Archive
            </span>
          </div>

          <nav className="hidden gap-8 text-sm md:flex">
            <a href="#">Library</a>
            <a href="#">Reading List</a>
            <a href="#">Stats</a>
            <a href="#">Profile</a>
          </nav>
        </div>
      </header>

      {/* HERO */}
      <section className="section-spacing">
        <div className="container-page flex flex-col items-center text-center">
          <p className="editorial-label mb-6">
            Project Gutenberg Reading Tracker
          </p>

          <h1 className="serif max-w-5xl text-6xl leading-none tracking-tight md:text-8xl">
            Build your personal reading archive.
          </h1>

          <p className="mt-8 max-w-2xl text-lg text-[var(--muted)]">
            Track classics, organize your reading journey,
            save highlights, and explore thousands of
            public domain books.
          </p>

          {/* SEARCH */}
          <div className="mt-14 w-full max-w-3xl">
            <input
              type="text"
              placeholder="Search books, authors, genres..."
              className="h-16 rounded-none px-6 text-lg"
            />
          </div>

          {/* TAGS */}
          <div className="mt-8 flex flex-wrap items-center justify-center gap-3">
            <span className="editorial-label">Try</span>

            {[
              "Dostoevsky",
              "Jane Austen",
              "Philosophy",
              "Poetry",
              "History",
            ].map((tag) => (
              <button
                key={tag}
                className="rounded-full border border-[var(--border)] px-5 py-2 text-sm transition hover:bg-[var(--foreground)] hover:text-[var(--background)]"
              >
                {tag}
              </button>
            ))}
          </div>
        </div>
      </section>

      {/* FEATURED BOOKS */}
      <section className="pb-32">
        <div className="container-page">
          <div className="mb-12 border-t border-[var(--border)] pt-8">
            <p className="editorial-label">
              Featured Collection
            </p>
          </div>

          <div className="grid gap-8 sm:grid-cols-2 lg:grid-cols-4">
            {books.map((book) => (
              <article
                key={book.title}
                className="group"
              >
                <div className="paper-card aspect-[3/4] overflow-hidden">
                  <div className="flex h-full items-center justify-center bg-[#ece4d8] p-6">
                    <h3 className="serif text-center text-3xl leading-tight">
                      {book.title}
                    </h3>
                  </div>
                </div>

                <div className="mt-5">
                  <h4 className="serif text-2xl">
                    {book.title}
                  </h4>

                  <p className="mt-1 text-sm text-[var(--muted)]">
                    {book.author}
                  </p>
                </div>
              </article>
            ))}
          </div>
        </div>
      </section>
    </main>
  );
}

const books = [
  {
    title: "Frankenstein",
    author: "Mary Shelley",
  },
  {
    title: "The Republic",
    author: "Plato",
  },
  {
    title: "Moby-Dick",
    author: "Herman Melville",
  },
  {
    title: "Pride & Prejudice",
    author: "Jane Austen",
  },
];