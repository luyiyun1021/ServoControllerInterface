### TODO: 
1. Restyle the table
2. Add pagination/infinite scroll
3. Connect `assets/` to backend 

#### 06/29/2022 ruiyiw
##### Notes
1. Please develop under **module** (rather than component), because Angular's built-in datatable (especially `*ngFor` clause) needs declaration of `CommonModule` in the `xxx.module.ts` file. (Please refer to: https://stackoverflow.com/questions/61113746/cant-bind-to-ngforof-since-it-isnt-a-known-property-of-div)
2. Please install `angular-datatables` via this link: https://l-lin.github.io/angular-datatables/#/getting-started. The dependencies won't fail if the npm is at version 16 (works fine on my side).

##### Research
1. Angular: Use module or component? (See: https://stackoverflow.com/questions/40073941/whats-the-difference-between-an-angular-component-and-module)
2. Another table template: https://l-lin.github.io/angular-datatables/#/basic/angular-way

##### Code
1. (done) Discard the previous `message` component, and create a `message`module, which `msgtable` as a new component affiliated to `message` module.
2. (done) Create a table according to the frame provided by the sponsor. Rewrite the `msgtable.component.ts` file. 
3. (done) Create a JSON file called `data.json` under `assets/`, preparing for backend linkage. 
   
#### 06/28/2022 ruiyiw
##### Research
1. Learn the basics of Angular: https://github.com/maximegris/angular-electron
2. Install dependencies
##### Code
1. (done) Create a component called `message`, lead "图标3" to the `./message` path
2. (~~error~~ solved 06/29) Implement Angular Material Datatable from examples provided by https://github.com/AndrewJBateman/angular-material-table
   1. Error message: `Can't bind to 'matRowDefColumns' since it isn't a known property of 'tr'`
   2. Possible reasons: material package too old? not compatible style files? template not working on brower view?
    
##### TODO
1. Solve the error 
2. OR switch to another table template

