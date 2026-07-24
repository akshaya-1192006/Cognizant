# Git Hands-On 05: Cleanup and Push

---

# Objective

Learn how to clean up a Git repository by deleting unnecessary branches and push the local repository to GitHub.

---

# What is Cleanup?

Cleanup is the process of removing branches that are no longer needed after they have been merged. This helps keep the repository organized.

---

# What is Push?

The `git push` command uploads local commits to a remote GitHub repository so that the changes are available online.

---

# Step 1: Check Available Branches

```bash
git branch
```

### Example Output

```text
* main
  feature
```

---

# Step 2: Delete the Merged Branch

```bash
git branch -d feature
```

### Example Output

```text
Deleted branch feature (was 8a7b1c2).
```

---

# Step 3: Verify the Branches

```bash
git branch
```

### Output

```text
* main
```

---

# Step 4: Add Remote Repository

```bash
git remote add origin https://github.com/username/repository-name.git
```

Check the remote repository.

```bash
git remote -v
```

### Example Output

```text
origin  https://github.com/username/repository-name.git (fetch)
origin  https://github.com/username/repository-name.git (push)
```

---

# Step 5: Push the Repository

```bash
git push -u origin main
```

### Example Output

```text
Enumerating objects: 8, done.
Counting objects: 100% (8/8), done.
Writing objects: 100% (8/8), done.
Branch 'main' set up to track remote branch 'main' from 'origin'.
```

---

# Step 6: Verify on GitHub

- Open your GitHub repository.
- Refresh the page.
- Verify that all committed files have been uploaded successfully.

---

# Workflow Diagram

```text
Complete Work
      │
      ▼
Merge Branch
      │
      ▼
Delete Feature Branch
      │
      ▼
Add Remote Repository
      │
      ▼
git push origin main
      │
      ▼
Files Available on GitHub
```

---

# Commands Used

| Command | Description |
|----------|-------------|
| `git branch` | Display available branches |
| `git branch -d feature` | Delete merged branch |
| `git remote add origin <repository-url>` | Add remote GitHub repository |
| `git remote -v` | View configured remote repositories |
| `git push -u origin main` | Push local repository to GitHub |

---

# Advantages

- Removes unnecessary branches.
- Keeps the repository clean and organized.
- Uploads the latest changes to GitHub.
- Enables collaboration with other developers.
- Creates a backup of the project online.

---

# What I Learned

- I learned how to delete merged branches.
- I learned how to connect a local repository to GitHub.
- I understood how to push commits to a remote repository.
- I learned how to verify that files were uploaded successfully.

---

# Conclusion

Cleanup and Push are the final steps in a basic Git workflow. Deleting unused branches keeps the repository organized, while pushing changes to GitHub ensures that the latest version of the project is safely stored online and can be shared with others.
