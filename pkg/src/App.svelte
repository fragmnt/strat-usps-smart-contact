<script>
	export let siteName;
	
    //	import Header from './components/Header.svelte';
</script>

<svelte:head>
	<title>Monitor consumer logistics trends on the blockchain • {siteName}</title>
</svelte:head>


<main>
	<nav>
		<h1>{siteName}</h1>
	</nav>
	Hello.
</main>

<style>
    main {

    }
	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>