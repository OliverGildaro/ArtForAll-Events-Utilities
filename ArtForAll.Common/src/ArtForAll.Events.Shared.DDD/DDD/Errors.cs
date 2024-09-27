namespace ArtForAll.Shared.Contracts.DDD
{
    public static class Errors
    {
        public static class Pitch
        {
            public static Error InvalidCategory(string name) =>
                new Error("pitch.category.invalid", $"The '{name}' is not valid for a pitch category.");

            public static Error InvalidFieldOfWork(string name) =>
                new Error("pitch.fieldOfWork.invalid", $"The '{name}' is not valid for a field of work pitch.");
        }

        public static class General
        {
            public static Error ValueIsInvalid() =>
                new Error("value.is.invalid", "Value is invalid");

            public static Error ValueIsRequired() =>
                new Error("value.is.required", "Value is required");

            public static Error NotFound(string? id = null)
            {
                string forId = id == null ? "" : $" for Id '{id}'";
                return new Error("record.not.found", $"Record not found{forId}");
            }

            public static Error InvalidLength(int length, string name = null)
            {
                string label = name == null ? " " : " " + name + " ";
                return new Error("invalid.string.length", $"Invalid{label}length - No More than: {length}");
            }

            public static Error InternalServerError(string message)
            {
                return new Error("internal.server.error", message);
            }

            public static Error InvalidQuantity(int quantity)
            {
                return new Error("invalid.int.quantity", $"This pitch can not have more tha '{quantity}' seats.");
            }
        }
    }
}
