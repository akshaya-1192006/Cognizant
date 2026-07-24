# Git Hands-On 02: Use `.gitignore`

---

# Objective

Learning how to use a `.gitignore` file to prevent unnecessary files and folders from being tracked by Git.

---

# What is `.gitignore`?

A `.gitignore` file tells Git which files and folders should **not** be tracked or committed to the repository.

It helps keep the repository clean by excluding temporary files, build files, logs, and other unnecessary files.

---

# Step 1: Create a Git Repository

```bash
mkdir GitIgnoreDemo
cd GitIgnoreDemo
git init
```

---

# Step 2: Create a `.gitignore` File

Create a file named:

```text
.gitignore
```

---

# Step 3: Add Ignore Rules

Example `.gitignore` file:

```text
# Ignore log files
*.log

# Ignore text files
*.txt

# Ignore build folder
bin/
obj/

# Ignore Visual Studio files
.vs/

# Ignore environment files
.env
```

---

# Step 4: Create Sample Files

```text
README.md
notes.txt
error.log
.env
```

---

# Step 5: Check Git Status

```bash
git status
```

### Output

```text
On branch master

Untracked files:
README.md
.gitignore
```

> Files such as `notes.txt`, `error.log`, and `.env` are ignored because they match the rules in `.gitignore`.

---

# Step 6: Add Files

```bash
git add .
```

---

# Step 7: Commit Changes

```bash
git commit -m "Added .gitignore file"
```

---

# Workflow Diagram

```text
Create Repository
        │
        ▼
Create .gitignore
        │
        ▼
Add Ignore Rules
        │
        ▼
Create Files
        │
        ▼
git status
        │
        ▼
git add .
        │
        ▼
git commit
```

---

# Common `.gitignore` Entries

| Pattern | Description |
|----------|-------------|
| `*.log` | Ignore all log files |
| `*.txt` | Ignore all text files |
| `.env` | Ignore environment file |
| `bin/` | Ignore build folder |
| `obj/` | Ignore object files |
| `.vs/` | Ignore Visual Studio settings |

---

# Commands Used

```bash
git init
git status
git add .
git commit -m "Added .gitignore file"
```

---

# What I Learned

- I learned the purpose of a `.gitignore` file.
- I learned how to prevent unwanted files from being tracked by Git.
- I understood how wildcard patterns work in `.gitignore`.
- I learned to keep a Git repository clean by ignoring temporary and generated files.

---

# Conclusion

The `.gitignore` file is an important part of every Git project. It prevents unnecessary files from being committed, making the repository cleaner and easier to manage.
