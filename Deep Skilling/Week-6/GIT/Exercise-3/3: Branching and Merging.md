# Git Hands-On 03: Branching and Merging

---

# Objective

Learning how to create branches, switch between branches, make changes independently, merge branches, and view the commit history.

---

# What is Branching?

A branch is an independent line of development in Git. It allows developers to work on new features or bug fixes without affecting the main project.

---

# What is Merging?

Merging is the process of combining changes from one branch into another. It helps integrate completed work into the main branch.

---

# Step 1: Check Existing Branch

```bash
git branch
```

### Output

```text
* main
```

---

# Step 2: Create a New Branch

```bash
git branch feature
```

Check available branches:

```bash
git branch
```

### Output

```text
* main
  feature
```

---

# Step 3: Switch to the New Branch

```bash
git checkout feature
```

Or using the newer command:

```bash
git switch feature
```

### Output

```text
Switched to branch 'feature'
```

---

# Step 4: Create or Modify a File

Example:

```text
feature.txt
```

Add some content:

```text
This is the Feature Branch.
```

---

# Step 5: Add and Commit Changes

```bash
git add .
git commit -m "Added feature file"
```

---

# Step 6: Switch Back to Main Branch

```bash
git checkout main
```

or

```bash
git switch main
```

---

# Step 7: Merge the Feature Branch

```bash
git merge feature
```

### Output

```text
Updating 8a7b1c2..4f6d8e9
Fast-forward
 feature.txt | 1 +
```

---

# Step 8: View Commit History

```bash
git log --oneline
```

### Example Output

```text
4f6d8e9 Added feature file
8a7b1c2 Initial Commit
```

---

# Step 9: Delete the Branch (Optional)

```bash
git branch -d feature
```

### Output

```text
Deleted branch feature.
```

---

# Workflow Diagram

```text
          main
            │
            │
            ▼
     git branch feature
            │
            ▼
      feature branch
            │
   Make Changes
            │
     git add .
            │
    git commit
            │
            ▼
   git checkout main
            │
            ▼
    git merge feature
            │
            ▼
      Updated main
```

---

# Commands Used

| Command | Description |
|----------|-------------|
| `git branch` | List branches |
| `git branch feature` | Create a new branch |
| `git checkout feature` | Switch to a branch |
| `git switch feature` | Alternative command to switch branches |
| `git add .` | Stage changes |
| `git commit -m "message"` | Commit changes |
| `git merge feature` | Merge feature branch into current branch |
| `git log --oneline` | View commit history |
| `git branch -d feature` | Delete a branch |

---

# Advantages of Branching

- Work on new features independently.
- Keep the main branch stable.
- Enable multiple developers to work simultaneously.
- Simplify testing before merging.

---

# Advantages of Merging

- Combines completed work into the main branch.
- Preserves project history.
- Makes collaboration easier.
- Integrates multiple developers' changes.

---

# What I Learned

- I learned how to create a new Git branch.
- I learned how to switch between branches.
- I understood how to commit changes in a branch.
- I learned how to merge a branch into the main branch.
- I learned how to delete a branch after merging.

---

# Conclusion

Branching and merging are important Git features that allow developers to work independently and safely combine their changes into the main project. They support efficient collaboration and help maintain a well-organized development workflow.
