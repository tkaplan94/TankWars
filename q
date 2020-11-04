[33mcommit 9556aab277a4c878b494f5a7b0df2e4b57e57702[m[33m ([m[1;36mHEAD -> [m[1;32mmaster[m[33m)[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Sat Mar 7 11:32:16 2020 -0800

    Tanks turn away from walls

[33mcommit 5f48052094444c654dddf830bd31e2a982f31682[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Sat Mar 7 10:37:09 2020 -0800

    Fixed Bug where tanks continued to shoot after target destroyed

[33mcommit 0a6eecdb19157731f86dd92ed79fd9ee22aa61e5[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Sat Mar 7 10:22:38 2020 -0800

    Deleted test scene

[33mcommit b87d8d9ac1f2e371802ed1159250b0e74977050e[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Thu Feb 27 21:19:33 2020 -0800

    Tanks properly shoot at targets
    
    BUG: tanks continue to fire after target is destroyed

[33mcommit ad87222339e8bda565f6db104239971ef08214d4[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Thu Feb 27 19:49:02 2020 -0800

    Fixed issue where targets kept shooting after leaving path

[33mcommit 23dbb6a16bd9efc4734b4ffbb2e184bdffd78dc5[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Thu Feb 27 19:26:17 2020 -0800

    Added Compass and implemented AI_Shooting basics
    
    Halted AI movement temporarily for user/input controls.
    Tanks automatically shoot when in specified radius.
    Need to integrate Compass Directions when checking for targets in path.

[33mcommit 56add7cd761141edd744e485a212618bd9fb049a[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Thu Feb 27 11:14:41 2020 -0800

    Fixed bullet collided with original tank
    
    BulletCollision was changed to allow bullets to collide with friendly tanks.
    This introduced a bug that prevented bullets from spawning.
    Removing turret/cylinder collider and ignoring collision with tank fixed this.
    Had to increase size of wall colliders to prevent turret from going into it.

[33mcommit a451fbdde0cc1276954b93beb4ec2e2f0dd78e41[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Wed Feb 26 13:23:46 2020 -0800

    Added new material and prefabs

[33mcommit 650d31ba3c5cdf24611616762cdde836e929b500[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Wed Feb 26 12:44:14 2020 -0800

    Added AI_Movement()
    
    AI_Movement decides randomly which direction to move in
    Move functions now check for that direction instead of input

[33mcommit efce3ec2da635587976386db75af925b6b529386[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Mon Feb 24 12:07:30 2020 -0800

    Resized arena

[33mcommit dd2d913687143c3a3b3b7a2da372a0437e8ac9f2[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Mon Feb 24 11:58:29 2020 -0800

    Resituated scene boundaries and tanks, editted tags

[33mcommit a402635f3d9287f7ff6303748cbab6962c149bed[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Mon Feb 24 11:13:16 2020 -0800

    Editted Floor material and renamed scene MainScene

[33mcommit 155f9f2595302f614c6020625e0ad20f4bc8676e[m
Author: Tyler Kaplan <tkaplan94@yahoo.com>
Date:   Fri Feb 21 12:07:21 2020 -0800

    Initial commit, added Assets folder for tracking
