<script>
	export let siteName;
	let toggled = false;

	import axios from 'axios';
	
	let loginToNode = async () => {
		await axios.post("/").then((res) => {
			return res.data;
		}).catch((e) => {
			console.log(e);
		});
	};

	let toggleLoginModal = () => {
		toggled = !toggled;
	};
</script>

<svelte:head>
	<title>Monitor consumer logistics trends on the blockchain • {siteName}</title>
</svelte:head>


<!-- toggled conditional modal -->

<main id="app">
	<nav class="navbar"
		style="background-color: #000; color: #FFF;"
	>
  		<span class="navbar-brand mb-0 h1">{siteName}</span>
		  <div>
		  	<button on:click={toggleLoginModal()}>Login</button>
		  </div>
	</nav>
	<div class="container-fluid">
  		<!-- Content here -->
		  <h1>True tracebility and parcel monitoring</h1>
		  <p>The USPS is a big bemoth awaiting innovative new tools. We're using the Stratis blockchain platform to do so.</p>
	</div>
</main> 

<style lang="scss">
	@font-face {
		font-family: 'Sofia Pro';
		src: url('/static/fonts/SofiaProLight.ttf')  format('truetype');
		font-weight: 500;
	}

	@font-face {
		font-family: 'Noe Text';
		font-weight: 700;
		src: url('/static/fonts/NoeTextRegular.woff') format('woff'),
	}

	h1 {
		font-family: 'Noe Text';
		font-family: 700;
		font-size: 44px;
	}

	p {
		font-family: 'Sofia Pro';
		font-weight: 500;
	}


    main {

    }
	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>