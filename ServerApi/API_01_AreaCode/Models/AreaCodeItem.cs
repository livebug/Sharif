namespace API_01_AreaCode.Models
{
    public class AreaCodeItem
    {
        /*
          `type` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
          `code` char(12) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
          `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
          `parent_code` char(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
          `short_code` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
          `catalog` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
          `sub` smallint(6) NULL DEFAULT NULL,
         */

        public string Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? ParentCode { get; set; }
        public string ShortCode { get; set; }
        public string? Catalog { get; set; }
        public int Sub { get; set; }
    }
}