window.showDeleteConfirm = async function (title) {
    const result = await Swal.fire({
        title: 'Are you sure?',
        text: `Do you want to delete "${title}"?`,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'Yes, delete it!',
    });

    return result.isConfirmed;
};
