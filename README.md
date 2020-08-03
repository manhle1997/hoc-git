project to learn Git

//git init
//git status
//git add
//git commit

//git log
//git show
//git driff

//working directory
là vùng mà file được thay đổi và chưa dc git add
//staging area
file nào sau khi được git add sẽ vào vùng staging area và chỉ file nào nằm trong staging area mới được commit
//git repository
Những file ở staging area sau khi được commit thì sẽ được đưa vào repository

//git checkout
git checkout cập nhật lại tất cả những thay đổi lại trạng thái lúc trước đó, nhưng file được checkout phải nằm trong vùng working dir
//git reset
git reset HEAD <file> là kéo 1 file ở vùng staging area về lại working dir,tìm hiểu thêm cả về git restore --staged <file> cũng có chức năng như của reset nhưng là ở phiên bản mới,