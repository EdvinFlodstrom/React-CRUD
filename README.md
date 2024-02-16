Journal
=======
This is a tutorial project. It follows the instructions of the following two links:
* https://www.c-sharpcorner.com/article/net-core-3-1-web-api-crud/
* https://www.c-sharpcorner.com/article/reactjs-crud-using-net-core-web-api/

2024-02-15
-----------
Never in my life have I struggled so much with setting up a Git repository, and I do not know why or what exactly happened. I ran 'git init' as usual, and somehow, perhaps I accidentally did it in the wrong folder first, Git had been initialized in a subfolder as well. I got it fixed by running 'git rm --cached react-crud -f', but that was only the beginning. After this, I initialized Git in the project root and added the repository on GitHub as a remote origin. As usual, in other words. I then added all the files and committed them. Around the same time, I also fetched the changes (adding the README.md file) from the repository on GitHub. I don't know what went wrong where, but nothing was working. The GitHub repository didn't update (the commit didn't appear), my local folder didn't update (the README.md file didn't appear), and I could not for the life of me figure out what was going on. I tried reverting the commit by going back to a previous version, but that seemed to accomplish nothing despite a successful status message. I tried committing and fetching several times with no progress. After over half an hour of pointless debugging, I simply removed the '.git' folder and initialized it again. Within three minutes, everything was working. I wish I knew what went wrong, but alas, I do not. What I do know, however, is that I will make *absolutely certain* that I run the correct commands at the correct time in the correct place next time. Debugging this was not fun. At all.

Anyhow before the events above transpired, I set up the frontend and backend projects, and the SQL database. It didn't go *too* well, but it might work, I suppose... It's all been a load of debugging and annoyance, so I hope the project will be more fun moving on.

What was it I said above? That pushing my local folder to the GitHub repository was going well after a while? That was a big lie, apparently. So after thinking that I'd gotten it working, I pushed the commit to GitHub. To the wrong branch. Like a complete buffoon. I probably shouldn't have struggled as much as I was. So I remade the repository and ran the following commands:
```ps
git remote add origin https://github.com/EdvinFlodstrom/React-CRUD.git
git branch -M main
git add .
git commit -m "Project initialized"
git push -u origin main
```
And it worked. For real this time, because I actually *followed exact instructions like I should have from the beginning*. I was trying to do it from my memory, and I suppose I got the things mixed up or something. Regardless, I think I've learned a lesson or two from all this. The repository is up, my changes are updated, and my sanity is restored.

2024-02-16
-----------
Apparently one of the packages, Microsoft.AspNetCore.Mvc.NewtonsoftJson, isn't compatible with .NET version 8, the one I created the project with. From what I can tell, the tutorial project seems a bit outdated, recommending .NET Core 3.1. I really don't feel like spending a lot of time trying to figure out which versions are compatible and recommended for each other, especially with the tutorial instructions being so vague as well. So, for now, I'm going to abandon this project as is, an initialized template of an empty API.