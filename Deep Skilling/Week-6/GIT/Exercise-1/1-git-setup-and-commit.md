# Git Hands-On 01: Setup Git & Adding a File

---

# Objective

Learning how to install Git, configure Git, create a local repository, add a file, and commit it to the repository.

---

# Prerequisites

- Git installed on your computer
- GitHub account
- Visual Studio Code (Recommended)

---

# Step 1: Verify Git Installation

Open Command Prompt or Terminal and run:

```bash
git --version
```

### Example Output

```text
git version 2.50.1
```

---

# Step 2: Configure Git

Set your username:

```bash
git config --global user.name "Your Name"
```

Set your email:

```bash
git config --global user.email "your@email.com"
```

Verify the configuration:

```bash
git config --list
```

---

# Step 3: Create a New Project Folder

```bash
mkdir GitDemo
cd GitDemo
```

---

# Step 4: Initialize Git Repository

```bash
git init
```

### Output

```text
Initialized empty Git repository in C:/GitDemo/.git/
```

---

# Step 5: Create a File

Create a file named **README.md**

Example content:

```text
Hello Git!
```

---

# Step 6: Check Repository Status

```bash
git status
```

### Output

```text
On branch master

No commits yet

Untracked files:
README.md
```

---

# Step 7: Add File to Staging Area

```bash
git add README.md
```

Or add all files:

```bash
git add .
```

---

# Step 8: Check Status Again

```bash
git status
```

### Output

```text
Changes to be committed:
new file: README.md
```

---

# Step 9: Commit the File

```bash
git commit -m "Initial Commit"
```

### Output

```text
[master (root-commit)] Initial Commit
1 file changed
create mode 100644 README.md
```

---

# Step 10: View Commit History

```bash
git log
```

### Example Output

```text
commit 5a7f6b...

Author: Your Name

Date: ...

Initial Commit
```

---

# Workflow Diagram

```text
Create Folder
      │
      ▼
git init
      │
      ▼
Create File
      │
      ▼
git status
      │
      ▼
git add .
      │
      ▼
git commit -m "Initial Commit"
      │
      ▼
git log
```

---

# Commands Used

| Command | Description |
|---------|-------------|
| `git --version` | Check Git version |
| `git config --global user.name` | Configure username |
| `git config --global user.email` | Configure email |
| `git init` | Initialize Git repository |
| `git status` | Show repository status |
| `git add` | Add files to staging area |
| `git commit` | Save changes |
| `git log` | Display commit history |

---

# What I Learned

- Installed and configured Git.
- Created a local Git repository.
- Added a new file to Git.
- Committed changes to the repository.
- Viewed the commit history using `git log`.

---

# Conclusion

This hands-on exercise introduced the basic Git workflow. I learned how to initialize a repository, add files, commit changes, and track project history using Git commands.
