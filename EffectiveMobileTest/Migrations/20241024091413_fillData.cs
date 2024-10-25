using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobileTest.Migrations
{
    /// <inheritdoc />
    public partial class fillData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "Orders",
                columns: new[] { "Id", "Weight", "CityDistrictId", "DeliveryDateTime" },
                values: new object[,]
                {
                    { "779d49cd-0ad8-4a17-8ca1-f407e7c3fc06", 5, "d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,24,23,18,41)},
                    { "dda6d21e-37d9-4599-bd9a-5d94a0fe6510", 50, "52b79d86-9a3b-4dfd-b6e2-538a11f4fb71", new DateTime(2024,10,25,1,22,41)},
                    { "ac3af156-e9f9-4b81-ae9f-58d634e4aea0", 45, "ca0f5f87-c5ee-4770-9225-876f6bef1231", new DateTime(2024,10,25,2,2,41)},
                    { "01d0626e-547d-4d33-9e80-4a819096d5ef", 35, "cf0a5c54-bde7-411d-bde0-898119b1e7c7", new DateTime(2024,10,25,1,40,41)},
                    { "b4e7b5c6-dcb2-4bc4-8d64-f672246450ee", 11, "636165c9-b796-41a4-a5bc-7a49b9e9e8fa", new DateTime(2024,10,25,23,18,41)},
                    { "57eb1989-df7e-4cfa-8f25-0446ee570b3a", 0.5f, "8adb7b85-10b0-474d-9077-dea50d79120f", new DateTime(2024,10,24,23,59,41)},
                    { "b413769b-8859-4e74-9286-a85656c0d84f", 22, "f5691bc9-f06c-4cda-a4ee-f2e758446919", new DateTime(2024,10,24,23,50,41)},
                    { "47451aaf-ccdd-4106-9a69-baf8eccfe373", 27.5f, "8adb7b85-10b0-474d-9077-dea50d79120f", new DateTime(2024,10,24,23,30,41)},
                    { "e681f8ea-d205-4a73-a635-446929ed4a80", 90, "d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,25,1,51,41)},
                    { "8cb5123d-81b9-4ef3-934e-ee7efef8c60f", 10000, "636165c9-b796-41a4-a5bc-7a49b9e9e8fa", new DateTime(2024,10,25,2,23,41)},
                    { "850694e3-7298-4b55-9e32-0414ed6550dc", 250, "52b79d86-9a3b-4dfd-b6e2-538a11f4fb71", new DateTime(2024,10,25,3,21,41) },
                    { "d0e3d236-89d9-43d9-8ef4-16ca2f9e28f6", 11.2f,"d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,25,3,41,41)},
                    { "7a88a607-2a3d-464c-81ec-19fa77acb330", 54, "f5691bc9-f06c-4cda-a4ee-f2e758446919", new DateTime(2024,10,24,23,55,41)},
                    { "c804e3b9-55f1-4824-a483-697f7e65e089", 125,"ca0f5f87-c5ee-4770-9225-876f6bef1231", new DateTime(2024,10,25,3,23,41)},
                    { "0ec5ac0f-8045-42b2-a46b-dc3c95259c9b", 53, "636165c9-b796-41a4-a5bc-7a49b9e9e8fa", new DateTime(2024,10,24,23,43,41)},
                    { "110ff6e0-b4a0-4bc7-832e-cfce02a4ec04", 78, "d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,25,3,42,41)},
                    { "35ef4e1c-33a0-430a-9f09-fb9e3e026547", 546,"f5691bc9-f06c-4cda-a4ee-f2e758446919", new DateTime(2024,10,25,3,2,41)},
                    { "13ff9187-0560-42a4-90b8-4696d9fca551", 34, "cf0a5c54-bde7-411d-bde0-898119b1e7c7", new DateTime(2024,10,24,23,11,41)},
                    { "2ccd2415-97e2-4030-88b9-32dad3fa2e0f", 643,"f5691bc9-f06c-4cda-a4ee-f2e758446919", new DateTime(2024,10,25,2,22,41)},
                    { "007c4220-b0ff-4e96-874d-194f3dff6aa3", 87, "d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,25,2,31,41)},
                    { "0deced59-61d6-4355-b605-6df9da716cab", 235, "8adb7b85-10b0-474d-9077-dea50d79120f", new DateTime(2024,10,24,23,42,41)},
                    { "5840f5b4-c016-4806-a05b-90c4e4c66ac8", 457, "636165c9-b796-41a4-a5bc-7a49b9e9e8fa", new DateTime(2024,10,25,23,33,41)},
                    { "530e567e-5b70-4871-a058-338b108e3b32", 36487, "ca0f5f87-c5ee-4770-9225-876f6bef1231", new DateTime(2024,10,24,23,56,41)},
                    { "af240c17-5d2e-4f53-aa04-c2a4ab5f6a66", 2, "cf0a5c54-bde7-411d-bde0-898119b1e7c7", new DateTime(2024,10,25,2,43,41)},
                    { "fde4c69b-36aa-4aaa-af02-7516ee41e25f", 3, "d193cfae-2bfa-4afe-9560-3521fcba14e5", new DateTime(2024,10,24,23,12,41)},
                    { "d2c4cec8-8e65-4384-8a78-c58f6c117a89", 436, "8adb7b85-10b0-474d-9077-dea50d79120f", new DateTime(2024,10,25,2,35,41)},
                    { "410648c6-cf67-4c06-871f-7032a5cf87ab", 4, "52b79d86-9a3b-4dfd-b6e2-538a11f4fb71", new DateTime(2024,10,24,23,14,41)},
                    { "39f52341-3029-4567-add9-33da8afc24e2", 87,"52b79d86-9a3b-4dfd-b6e2-538a11f4fb71", new DateTime(2024,10,25,1,22,41)},
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "Orders",
                keyColumn: "Id",
                keyValues: new object[]
                {
                    "779d49cd-0ad8-4a17-8ca1-f407e7c3fc06",
                    "dda6d21e-37d9-4599-bd9a-5d94a0fe6510",
                    "ac3af156-e9f9-4b81-ae9f-58d634e4aea0",
                    "01d0626e-547d-4d33-9e80-4a819096d5ef",
                    "b4e7b5c6-dcb2-4bc4-8d64-f672246450ee",
                    "57eb1989-df7e-4cfa-8f25-0446ee570b3a",
                    "b413769b-8859-4e74-9286-a85656c0d84f",
                    "47451aaf-ccdd-4106-9a69-baf8eccfe373",
                    "e681f8ea-d205-4a73-a635-446929ed4a80",
                    "8cb5123d-81b9-4ef3-934e-ee7efef8c60f",
                    "850694e3-7298-4b55-9e32-0414ed6550dc",
                    "d0e3d236-89d9-43d9-8ef4-16ca2f9e28f6",
                    "7a88a607-2a3d-464c-81ec-19fa77acb330",
                    "c804e3b9-55f1-4824-a483-697f7e65e089",
                    "0ec5ac0f-8045-42b2-a46b-dc3c95259c9b",
                    "110ff6e0-b4a0-4bc7-832e-cfce02a4ec04",
                    "35ef4e1c-33a0-430a-9f09-fb9e3e026547",
                    "13ff9187-0560-42a4-90b8-4696d9fca551",
                    "2ccd2415-97e2-4030-88b9-32dad3fa2e0f",
                    "007c4220-b0ff-4e96-874d-194f3dff6aa3",
                    "0deced59-61d6-4355-b605-6df9da716cab",
                    "5840f5b4-c016-4806-a05b-90c4e4c66ac8",
                    "530e567e-5b70-4871-a058-338b108e3b32",
                    "af240c17-5d2e-4f53-aa04-c2a4ab5f6a66",
                    "fde4c69b-36aa-4aaa-af02-7516ee41e25f",
                    "d2c4cec8-8e65-4384-8a78-c58f6c117a89",
                    "410648c6-cf67-4c06-871f-7032a5cf87ab",
                    "39f52341-3029-4567-add9-33da8afc24e2"
                });
        }
    }
}
