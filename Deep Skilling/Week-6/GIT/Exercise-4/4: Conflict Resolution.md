# Git Hands-On 04: Conflict Resolution

---

# Objective

Learn how Git merge conflicts occur and how to resolve them when two branches modify the same part of a file.

---

# What is a Merge Conflict?

A merge conflict occurs when Git cannot automatically combine changes from two different branches because the same lines in a file were modified.

Git asks the developer to manually choose which changes should be kept.

---

# Step 1: Create a Repository

```bash
mkdir ConflictDemo
cd ConflictDemo
git init
```

---

# Step 2: Create a File

Create a file named **README.md**

```text
Welcome to Git Hands-On
```

---

# Step 3: Commit the File

```bash
git add .
git commit -m "Initial Commit"
```

---

# Step 4: Create a New Branch

```bash
git branch feature
git checkout feature
```

---

# Step 5: Modify the File in Feature Branch

Change the file to:

```text
Welcome to Feature Branch
```

Save the file and commit it.

```bash
git add .
git commit -m "Updated README in feature branch"
```

---

# Step 6: Switch to Main Branch

```bash
git checkout main
```

---

# Step 7: Modify the Same File

Change the file to:

```text
Welcome to Main Branch
```

Commit the changes.

```bash
git add .
git commit -m "Updated README in main branch"
```

---

# Step 8: Merge Feature Branch

```bash
git merge feature
```

### Output

```text
Auto-merging README.md
CONFLICT (content): Merge conflict in README.md
Automatic merge failed; fix conflicts and then commit the result.
```

---

# Step 9: Open the File

Git marks the conflicting changes like this:

```text
<<<<<<< HEAD
Welcome to Main Branch
=======
Welcome to Feature Branch
>>>>>>> feature
```

---

# Step 10: Resolve the Conflict

Edit the file manually.

Example:

```text
Welcome to Main Branch
Welcome to Feature Branch
```

or choose the version you want to keep.

Remove all conflict markers:

```text
<<<<<<<
=======
>>>>>>>
```

Save the file.

---

# Step 11: Add and Commit the Resolved File

```bash
git add README.md
git commit -m "Resolved merge conflict"
```

---

# Step 12: Check Commit History

```bash
git log --oneline
```

### Example Output

```text
f5b7d11 Resolved merge conflict
a4d8f30 Updated README in feature branch
8b9c215 Updated README in main branch
3e4f1d2 Initial Commit
```

---

# Workflow Diagram

```text
              main
                │
                │
                ▼
         Initial Commit
                │
      ┌─────────┴─────────┐
      │                   │
      ▼                   ▼
 Feature Branch      Main Branch
      │                   │
 Modify File         Modify Same File
      │                   │
 Commit              Commit
      │                   │
      └─────────┬─────────┘
                │
                ▼
          git merge feature
                │
         Merge Conflict
                │
      Edit File Manually
                │
                ▼
      git add README.md
                │
                ▼
 git commit -m "Resolved merge conflict"
```

---

# Commands Used

| Command | Description |
|----------|-------------|
| `git branch feature` | Create a new branch |
| `git checkout feature` | Switch to feature branch |
| `git checkout main` | Switch to main branch |
| `git merge feature` | Merge feature branch |
| `git status` | Show repository status |
| `git add README.md` | Stage the resolved file |
| `git commit -m "Resolved merge conflict"` | Commit the resolved changes |
| `git log --oneline` | View commit history |

---

# Advantages

- Protects code from accidental overwrites.
- Helps developers review conflicting changes.
- Improves collaboration in team projects.
- Preserves the complete history of changes.

---

# What I Learned

- I learned what a merge conflict is.
- I understood why merge conflicts occur.
- I learned how to identify conflict markers.
- I learned how to resolve conflicts manually.
- I learned how to complete the merge after resolving conflicts.

---

# Conclusion

Merge conflicts are a common part of collaborative software development. By identifying conflicting changes, editing the file manually, and committing the resolved version, developers can safely combine work from multiple branches while maintaining project integrity.
