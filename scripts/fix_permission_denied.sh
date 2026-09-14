DB_DIR="./db_datas"

# crée le dossier des datas
mkdir -p $DB_DIR

# change le propriétaire sur l'UID que SQL Server utilise (10001)
sudo chown -R 10001:10001 $DB_DIR

# sécuriser permissions (lecture/écriture pour owner)
sudo chmod -R 700 $DB_DIR
