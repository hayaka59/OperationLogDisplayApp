## MySQLへの外部接続を許可する設定。
### 接続する側のPCでMySqlを実行し、下記のコマンドを実行する。
###	(1) create user 'devuser'@'srobo007' identified by 'Pf6QfXcQ';
###	(2) grant all on *.* to 'devuser'@'srobo007' with grant option;
###	(3) flush privileges;
### ※ 'srobo007'は接続元のホスト名
