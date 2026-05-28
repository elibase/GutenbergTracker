import "../app/globals.css"

export default function LoginPage() {
  return (
    <main className="flex min-h-screen items-center justify-center bg-[var(--background)] px-6 py-12">
      <div className="paper-card w-full max-w-md p-10">
        {/* HEADER */}
        <div className="mb-10 text-center">
          <p className="editorial-label mb-4">
            GutenTracker
          </p>

          <h1 className="serif text-5xl">
            Welcome back
          </h1>

          <p className="mt-4 text-sm text-[var(--muted)]">
            Continue your reading journey through the
            public domain.
          </p>
        </div>

        {/* FORM */}
        <form className="space-y-5">
          <div>
            <label className="mb-2 block text-sm">
              Email
            </label>

            <input
              type="email"
              placeholder="you@example.com"
              className="h-14 px-4"
            />
          </div>

          <div>
            <label className="mb-2 block text-sm">
              Password
            </label>

            <input
              type="password"
              placeholder="••••••••"
              className="h-14 px-4"
            />
          </div>

          <button className="mt-4 h-14 w-full border border-[var(--foreground)] bg-[var(--foreground)] text-sm uppercase tracking-[0.15em] text-[var(--background)] transition hover:opacity-90">
            Sign In
          </button>
        </form>

        {/* DIVIDER */}
        <div className="my-8 flex items-center gap-4">
          <div className="h-px flex-1 bg-[var(--border)]" />

          <span className="text-xs uppercase tracking-[0.18em] text-[var(--muted)]">
            Or
          </span>

          <div className="h-px flex-1 bg-[var(--border)]" />
        </div>

        {/* GOOGLE */}
        <button className="flex h-14 w-full items-center justify-center gap-3 border border-[var(--border)] bg-[var(--surface)] transition hover:bg-[#efe7da]">
          <svg
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 48 48"
            className="h-5 w-5"
          >
            <path
              fill="#FFC107"
              d="M43.6 20.5H42V20H24v8h11.3C33.6 32.7 29.2 36 24 36c-6.6 0-12-5.4-12-12S17.4 12 24 12c3 0 5.8 1.1 7.9 3l5.7-5.7C34.1 6.1 29.3 4 24 4 12.9 4 4 12.9 4 24s8.9 20 20 20 20-8.9 20-20c0-1.3-.1-2.3-.4-3.5z"
            />

            <path
              fill="#FF3D00"
              d="M6.3 14.7l6.6 4.8C14.7 15 19 12 24 12c3 0 5.8 1.1 7.9 3l5.7-5.7C34.1 6.1 29.3 4 24 4 16.3 4 9.7 8.3 6.3 14.7z"
            />

            <path
              fill="#4CAF50"
              d="M24 44c5.1 0 9.8-1.9 13.4-5.1l-6.2-5.2C29.1 35.1 26.7 36 24 36c-5.2 0-9.6-3.3-11.3-8l-6.5 5C9.5 39.5 16.2 44 24 44z"
            />

            <path
              fill="#1976D2"
              d="M43.6 20.5H42V20H24v8h11.3c-1.1 3.1-3.3 5.4-6.1 6.9l6.2 5.2C39.2 36.6 44 31 44 24c0-1.3-.1-2.3-.4-3.5z"
            />
          </svg>

          <span className="text-sm">
            Continue with Google
          </span>
        </button>

        {/* FOOTER */}
        <p className="mt-8 text-center text-sm text-[var(--muted)]">
          Don&apos;t have an account?{" "}
          <a
            href="/register"
            className="text-[var(--foreground)]"
          >
            Create one
          </a>
        </p>
      </div>
    </main>
  );
}