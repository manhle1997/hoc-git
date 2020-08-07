project to learn Git

//git init
điều đầu 
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

//git checkout -b <branch> (branching)
dùng để tạo nhánh mới bắt đầu từ nhánh đang dùng, nếu nhánh đấy đã có rồi mà vẫn tạo thì sẽ báo lỗi
//git checkout <branch> 
dùng để chuyển qua lại giữa các nhánh
//git merge
A <--- B : kéo thay đổi từ branch B sang branch A 
trong trường hợp này cụ thể ta muốn kéo những thay đổi từ branch feature/hippo-class về master tức là
master <--- feature/hippo-class

B1: phải checkout về nhánh chính A tức là nhánh master : git checkout master
B2: kéo nhánh B về nhánh hiện tại tức là nhánh A.: git merge <B> : git merge feature/hippo-class
//git branch -D <branch> (delete branch)

//git reset --soft <ID của branch cha>
Đưa những file đã commit về trạng thái staging area
//git reset --mixed
đưa những file đã commit về trạng thái working directory
//git reset --hard 
xoá luôn commit hiện tại

//.gitignore
khi tạo mới file nhưng không muốn commit file đấy thì tên file sẽ được đặt trong .gitignore. Khi đấy kiểm tra bằng git status sẽ không hiển thị file đấy nữa, khi git add thì cũng sẽ không add file đấy 